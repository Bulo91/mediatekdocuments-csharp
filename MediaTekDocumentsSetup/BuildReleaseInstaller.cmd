@echo off
setlocal
set "ROOT=%~dp0.."
set "SLN=%ROOT%\MediaTekDocuments.sln"
set "VDPROJ=%ROOT%\MediaTekDocumentsSetup\MediaTekDocumentsSetup.vdproj"
set "MSI=%ROOT%\MediaTekDocumentsSetup\Release\MediaTekDocumentsSetup.msi"
set "DEVENV=C:\Program Files\Visual Studio\Common7\IDE\devenv.com"

echo [1/3] Compilation Release du projet Setup...
"%DEVENV%" "%SLN%" /build "Release" /project "%VDPROJ%"
if errorlevel 1 exit /b 1

echo [2/3] Ajout des raccourcis Bureau et Menu Demarrer...
call "%ROOT%\MediaTekDocumentsSetup\BuildShortcuts.cmd" "%MSI%"
if errorlevel 1 exit /b 1

echo [3/3] Copie vers livrables...
if not exist "%ROOT%\livrables" mkdir "%ROOT%\livrables"
copy /Y "%MSI%" "%ROOT%\livrables\MediaTekDocumentsSetup.msi" >nul
copy /Y "%ROOT%\MediaTekDocumentsSetup\Release\setup.exe" "%ROOT%\livrables\setup.exe" >nul

echo Termine.
echo MSI : %MSI%
exit /b 0
