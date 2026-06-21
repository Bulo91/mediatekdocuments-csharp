param(
    [Parameter(Mandatory = $true)]
    [string]$MsiPath
)

$ErrorActionPreference = 'Stop'
$MsiPath = (Resolve-Path $MsiPath).Path
$ShortcutName = 'MediaTekDocuments'

$installer = New-Object -ComObject WindowsInstaller.Installer
$db = $installer.OpenDatabase($MsiPath, 1)

function Invoke-MsiView {
    param([string]$Sql, [scriptblock]$Bind, [switch]$FetchAll)
    $view = $db.OpenView($Sql)
    if ($Bind) { & $Bind $view }
    $view.Execute()
    if ($FetchAll) {
        $rows = @()
        while ($true) {
            try {
                $rec = $view.Fetch()
                if ($null -eq $rec) { break }
                $rows += $rec
            } catch { break }
        }
        $view.Close()
        return $rows
    }
    $view.Close()
}

function Get-ShortcutCount {
    try {
        $view = $db.OpenView('SELECT `Shortcut` FROM `Shortcut`')
        $view.Execute()
        $count = 0
        while ($true) {
            try {
                $null = $view.Fetch()
                $count++
            } catch {
                break
            }
        }
        $view.Close()
        return $count
    } catch {
        return 0
    }
}

$shortcutCount = Get-ShortcutCount
if ($shortcutCount -gt 0) {
    Write-Host "Raccourcis déjà présents dans le MSI ($shortcutCount)."
    exit 0
}

$exeFileKey = $null
foreach ($rec in (Invoke-MsiView 'SELECT `File`, `FileName` FROM `File`' -FetchAll)) {
    $fileName = $rec.StringData(2)
    if ($fileName -match '\|MediaTekDocuments\.exe$' -or $fileName -eq 'MediaTekDocuments.exe') {
        $exeFileKey = $rec.StringData(1)
        break
    }
}
if (-not $exeFileKey) {
    Write-Error 'MediaTekDocuments.exe introuvable dans le MSI.'
    exit 1
}

function Set-MsiProperty {
    param([string]$Name, [string]$Value)
    $del = $db.OpenView('DELETE FROM `Property` WHERE `Property` = ?')
    $delRec = $installer.CreateRecord(1)
    $delRec.StringData(1) = $Name
    $del.Execute($delRec)
    $del.Close()
    $ins = $db.OpenView('INSERT INTO `Property` (`Property`, `Value`) VALUES (?, ?)')
    $insRec = $installer.CreateRecord(2)
    $insRec.StringData(1) = $Name
    $insRec.StringData(2) = $Value
    $ins.Execute($insRec)
    $ins.Close()
}

function Add-MsiRow {
    param([string]$Sql, [int]$FieldCount, [string[]]$Values)
    $view = $db.OpenView($Sql)
    $rec = $installer.CreateRecord($FieldCount)
    for ($i = 0; $i -lt $Values.Count; $i++) {
        $rec.StringData($i + 1) = $Values[$i]
    }
    $view.Execute($rec)
    $view.Close()
}

Set-MsiProperty 'DISABLEADVTSHORTCUTS' '1'

$target = "[#$exeFileKey]"
$workDir = '[TARGETDIR]'
$desktopComponent = 'C__scDesktopMTK'
$menuComponent = 'C__scMenuMTK'
$desktopShortcut = 'scDesktopMTK'
$menuShortcut = 'scMenuMTK'

Add-MsiRow 'INSERT INTO `Component` (`Component`, `ComponentId`, `Directory_`, `Attributes`, `Condition`, `KeyPath`) VALUES (?, ?, ?, ?, ?, ?)' 6 @(
    $desktopComponent, "{$([guid]::NewGuid().ToString().ToUpper())}", 'DesktopFolder', '256', '', $desktopShortcut
)
Add-MsiRow 'INSERT INTO `Component` (`Component`, `ComponentId`, `Directory_`, `Attributes`, `Condition`, `KeyPath`) VALUES (?, ?, ?, ?, ?, ?)' 6 @(
    $menuComponent, "{$([guid]::NewGuid().ToString().ToUpper())}", 'ProgramMenuFolder', '256', '', $menuShortcut
)
Add-MsiRow 'INSERT INTO `FeatureComponents` (`Feature_`, `Component_`) VALUES (?, ?)' 2 @('DefaultFeature', $desktopComponent)
Add-MsiRow 'INSERT INTO `FeatureComponents` (`Feature_`, `Component_`) VALUES (?, ?)' 2 @('DefaultFeature', $menuComponent)
Add-MsiRow 'INSERT INTO `Shortcut` (`Shortcut`, `Directory_`, `Name`, `Component_`, `Target`, `Arguments`, `Description`, `Hotkey`, `Icon_`, `IconIndex`, `ShowCmd`, `WkDir`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)' 12 @(
    $desktopShortcut, 'DesktopFolder', $ShortcutName, $desktopComponent, $target, '', $ShortcutName, '', '', '0', '1', $workDir
)
Add-MsiRow 'INSERT INTO `Shortcut` (`Shortcut`, `Directory_`, `Name`, `Component_`, `Target`, `Arguments`, `Description`, `Hotkey`, `Icon_`, `IconIndex`, `ShowCmd`, `WkDir`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)' 12 @(
    $menuShortcut, 'ProgramMenuFolder', $ShortcutName, $menuComponent, $target, '', $ShortcutName, '', '', '0', '1', $workDir
)

$db.Commit()
Write-Host "Raccourcis ajoutés : Bureau + Menu Démarrer (exe=$exeFileKey)."
