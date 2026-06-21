"""Ajoute les raccourcis Bureau et Menu Demarrer au MSI Setup."""
import msilib
import sys
import uuid
from pathlib import Path

MSI_PATH = Path(sys.argv[1]) if len(sys.argv) > 1 else Path(__file__).parent / "Release" / "MediaTekDocumentsSetup.msi"
SHORTCUT_NAME = "MediaTekDocuments"


def find_exe_file_key(db):
    view = db.OpenView("SELECT File, FileName FROM File")
    view.Execute(None)
    rec = view.Fetch()
    while rec:
        file_key = rec.GetString(1)
        file_name = rec.GetString(2)
        if file_name.endswith("|MediaTekDocuments.exe") or file_name == "MediaTekDocuments.exe":
            view.Close()
            return file_key
        rec = view.Fetch()
    view.Close()
    raise RuntimeError("MediaTekDocuments.exe introuvable dans le MSI.")


def shortcut_count(db):
    try:
        view = db.OpenView("SELECT Shortcut FROM Shortcut")
        view.Execute(None)
        count = 0
        rec = view.Fetch()
        while rec:
            count += 1
            rec = view.Fetch()
        view.Close()
        return count
    except msilib.MSIError:
        return 0


def set_property(db, name, value):
    view = db.OpenView(f"DELETE FROM Property WHERE Property = '{name}'")
    view.Execute(None)
    view.Close()
    view = db.OpenView("INSERT INTO Property (Property, Value) VALUES (?, ?)")
    rec = msilib.CreateRecord(2)
    rec.SetString(1, name)
    rec.SetString(2, value)
    view.Execute(rec)
    view.Close()


def add_row(db, sql, values, int_fields=None):
    int_fields = int_fields or set()
    view = db.OpenView(sql)
    rec = msilib.CreateRecord(len(values))
    for i, val in enumerate(values, start=1):
        if i in int_fields:
            rec.SetInteger(i, int(val))
        else:
            rec.SetString(i, val)
    view.Execute(rec)
    view.Close()


def add_shortcut_component(db, component_id, directory, shortcut_id, registry_id, feature):
    comp_sql = (
        "INSERT INTO Component (Component, ComponentId, Directory_, Attributes, Condition, KeyPath) "
        "VALUES (?, ?, ?, ?, ?, ?)"
    )
    # Attributes 4 = msidbComponentAttributesRegistryKeyPath
    add_row(
        db,
        comp_sql,
        [
            component_id,
            "{" + str(uuid.uuid4()).upper() + "}",
            directory,
            "4",
            "",
            registry_id,
        ],
    )

    reg_sql = "INSERT INTO Registry (Registry, Root, `Key`, Name, Value, Component_) VALUES (?, ?, ?, ?, ?, ?)"
    add_row(
        db,
        reg_sql,
        [
            registry_id,
            "1",
            r"Software\MediaTek86\MediaTekDocuments",
            shortcut_id,
            "#1",
            component_id,
        ],
        int_fields={2},
    )

    fc_sql = "INSERT INTO FeatureComponents (Feature_, Component_) VALUES (?, ?)"
    add_row(db, fc_sql, [feature, component_id])


def main():
    msi_path = MSI_PATH.resolve()
    if not msi_path.exists():
        print(f"MSI introuvable : {msi_path}", file=sys.stderr)
        return 1

    db = msilib.OpenDatabase(str(msi_path), msilib.MSIDBOPEN_DIRECT)
    if shortcut_count(db) > 0:
        print(f"Raccourcis deja presents ({shortcut_count(db)}).")
        return 0

    exe_key = find_exe_file_key(db)
    target = f"[#{exe_key}]"
    work_dir = "[TARGETDIR]"

    desktop_component = "C__scDesktopMTK"
    menu_component = "C__scMenuMTK"
    desktop_shortcut = "scDesktopMTK"
    menu_shortcut = "scMenuMTK"
    desktop_registry = "regDesktopMTK"
    menu_registry = "regMenuMTK"

    set_property(db, "DISABLEADVTSHORTCUTS", "1")

    add_shortcut_component(
        db, desktop_component, "DesktopFolder", desktop_shortcut, desktop_registry, "DefaultFeature"
    )
    add_shortcut_component(
        db, menu_component, "ProgramMenuFolder", menu_shortcut, menu_registry, "DefaultFeature"
    )

    sc_sql = (
        "INSERT INTO Shortcut (Shortcut, Directory_, Name, Component_, Target, Arguments, Description, "
        "Hotkey, Icon_, IconIndex, ShowCmd, WkDir) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
    )

    def add_shortcut(sc_id, directory, component):
        add_row(
            db,
            sc_sql,
            [
                sc_id,
                directory,
                SHORTCUT_NAME,
                component,
                target,
                "",
                SHORTCUT_NAME,
                "",
                "",
                "0",
                "1",
                work_dir,
            ],
        )

    add_shortcut(desktop_shortcut, "DesktopFolder", desktop_component)
    add_shortcut(menu_shortcut, "ProgramMenuFolder", menu_component)

    db.Commit()
    print(f"Raccourcis ajoutes : Bureau + Menu Demarrer (exe={exe_key}).")
    return 0


if __name__ == "__main__":
    sys.exit(main())
