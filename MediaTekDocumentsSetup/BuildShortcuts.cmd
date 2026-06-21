@echo off
setlocal
set "DIR=%~dp0"
set "MSI=%~1"
if "%MSI%"=="" (
  echo BuildShortcuts: chemin MSI manquant
  exit /b 1
)
python "%DIR%AddMsiShortcuts.py" "%MSI%"
exit /b %ERRORLEVEL%
