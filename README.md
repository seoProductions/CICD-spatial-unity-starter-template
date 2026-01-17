# CICD Template for Unity-SpatialIO


Config:
- `Packages/manifest.json` replaced spatialSDK scoped-registry with a local one
- updated `Packages/packages-lock.json` setting spatialSDK package to local
- updated `ProjectSettings/PackageManagerSettings.asset` spatialSDK package to local

SDK changes:

- `SpatialSys.UnitySDK.Editor.BuildUtility.BuildAndUploadForSandbox` Created overloaded method for *-batchmode* comand line support
- `SpatialSys.UnitySDK.Editor.UpgradeUtility.CheckForUpgrade` Due to the nature of the local spatialSDK, I removed support for automatic SDK upgrades.
- `SpatialSys.UnitySDK.Editor.SpatialFeatureFlags` Set member variable to a permanent enabled. A nessesary evil 🫢


Local execution:

Publish to spatial.io via Powershell

 & 'C:\Program Files\Unity\Hub\Editor\2021.3.21f1\Editor\Unity.exe' -projectPath C:\Users\Seo\TestSpatialBuild\CICD-spatial-unity-starter-template\ -executeMethod SpatialSys.UnitySDK.Editor.BuildUtility.BuildAndPublishPackage -batchmode

Spatial.io "Test Scene" via Powershell

& 'C:\Program Files\Unity\Hub\Editor\2021.3.21f1\Editor\Unity.exe' -projectPath C:\Users\Seo\TestSpatialBuild\CICD-spatial-unity-starter-template\ -executeMethod SpatialSys.UnitySDK.Editor.BuildUtility.BuildAndUploadForSandbox -accept-apiupdate -batchmode


Note: 
The -nographics flag breaks the logging functionality.
The -quit       flag quits instantly, impeding any spatial.io publishing/testing to process
