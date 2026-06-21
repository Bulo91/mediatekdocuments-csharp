import msilib
import sys

db = msilib.OpenDatabase(sys.argv[1], msilib.MSIDBOPEN_READONLY)
for table in sys.argv[2:]:
    print(f"=== {table} ===")
    view = db.OpenView(f"SELECT * FROM {table}")
    view.Execute(None)
    rec = view.Fetch()
    while rec:
        vals = []
        for i in range(1, rec.GetFieldCount() + 1):
            try:
                vals.append(rec.GetString(i))
            except Exception:
                try:
                    vals.append(str(rec.GetInteger(i)))
                except Exception:
                    vals.append("?")
        print(vals)
        rec = view.Fetch()
    view.Close()
