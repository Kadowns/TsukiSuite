@echo off
SET SCRIPTS_LOCATION=%~dp0
SET ROOT_LOCATION=%SCRIPTS_LOCATION%..
SET BUILD_LOCATION=%SCRIPTS_LOCATION%Build
echo Using %SCRIPTS_LOCATION% as scripts location...
echo Using %ROOT_LOCATION% as root location...
echo Using %BUILD_LOCATION% as build location...
for /D %%d IN (dir .. /b /ad-h) do echo "Dir = %%d"