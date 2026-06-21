param([string]$MsiPath)
$inst = New-Object -ComObject WindowsInstaller.Installer
$db = $inst.OpenDatabase($MsiPath, 0)
function Query-Msi($sql) {
    $view = $db.OpenView($sql)
    $view.Execute()
    $rows = @()
    while ($true) {
        try { $r = $view.Fetch() } catch { break }
        if ($null -eq $r) { break }
        $row = @()
        for ($i = 1; $i -le $r.FieldCount; $i++) { $row += $r.StringData($i) }
        $rows += ,($row -join ' | ')
    }
    $view.Close()
    return $rows
}
Write-Host '=== Shortcut ==='
Query-Msi 'SELECT Shortcut, Directory_, Name, Component_, Target FROM Shortcut' | ForEach-Object { Write-Host $_ }
Write-Host '=== Exe File ==='
Query-Msi "SELECT File, Component_, FileName FROM File WHERE FileName LIKE '%TEKDO~1%'" | ForEach-Object { Write-Host $_ }
Query-Msi "SELECT File, Component_, FileName FROM File WHERE FileName LIKE '%.EXE%'" | ForEach-Object { Write-Host $_ }
Write-Host '=== Directory ==='
Query-Msi 'SELECT Directory, Directory_Parent, DefaultDir FROM Directory' | ForEach-Object { Write-Host $_ }
