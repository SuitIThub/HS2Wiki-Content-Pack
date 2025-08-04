@echo off
echo Creating package...

:: Set output zip filename
set ZIPFILE=HS2Wiki_Content_Package.zip

:: Create temporary folder structure
if exist temp rmdir /s /q temp
mkdir temp\BepInEx\plugins\HS2Wiki

:: Copy DLL
if exist obj\Debug\HS2Wiki_Content.dll (
    echo Copying DLL...
    xcopy obj\Debug\HS2Wiki_Content.dll temp\BepInEx\plugins\HS2Wiki\ /y
) else (
    echo ERROR: DLL not found at obj\Debug\HS2Wiki_Content.dll
    goto :error
)

:: Copy images with subfolder structure
echo Copying images with folder structure...
xcopy images\*.png temp\BepInEx\plugins\HS2Wiki\ /s /e /i /y

:: Create ZIP file using PowerShell
echo Creating ZIP archive...
powershell -Command "& {Compress-Archive -Path temp\* -DestinationPath %ZIPFILE% -Force}"

:: Clean up temp folder
rmdir /s /q temp

if exist %ZIPFILE% (
    echo Package created successfully: %ZIPFILE%
) else (
    echo ERROR: Failed to create package
    goto :error
)

goto :end

:error
echo Packaging failed!
exit /b 1

:end
echo Done.