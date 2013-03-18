call "C:\Program Files (x86)\Microsoft Visual Studio 8\Common7\IDE\devenv.com" PayPalPermissionsSDK\PayPalPermissionsSDK.sln /build Release

copy /Y PayPalPermissionsSDK\bin\Release\PayPalPermissionsSDK.dll Samples\PermissionsSampleApp\lib\. 
copy /Y PayPalPermissionsSDK\bin\Release\PayPalPermissionsSDK.XML Samples\PermissionsSampleApp\lib\. 
