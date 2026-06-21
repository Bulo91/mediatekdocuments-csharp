param([string]$MsiPath)
$ErrorActionPreference = 'Stop'
$installer = New-Object -ComObject WindowsInstaller.Installer
$db = $installer.OpenDatabase($MsiPath, 0)
$view = $db.OpenView("SELECT Shortcut, Name FROM Shortcut")
$view.Execute()
$count = 0
while ($true) {
    try {
        $rec = $view.Fetch()
        if ($null -eq $rec) { break }
        $count++
        Write-Host "$($rec.StringData(1)) -> $($rec.StringData(2))"
    } catch {
        break
    }
}
$view.Close()
Write-Host "Shortcut count: $count"
