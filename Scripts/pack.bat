call load
mkdir %BUILD_LOCATION%
del %BUILD_LOCATION%\*.nupkg
nuget pack %ROOT_LOCATION%\UnityUtilities\UnityUtilities.csproj -OutputDirectory %BUILD_LOCATION%
nuget pack %ROOT_LOCATION%\UnityEditorUtilities\UnityEditorUtilities.csproj -OutputDirectory %BUILD_LOCATION%