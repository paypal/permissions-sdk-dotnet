call "C:\Program Files (x86)\Microsoft Visual Studio 8\Common7\IDE\devenv.com" PayPal_Permissions_SDK\PayPal_Permissions_SDK.sln /build Release %1

copy /Y PayPal_Permissions_SDK\bin\Release\PayPal_Permissions_SDK.dll Samples\PermissionsSampleApp\lib\. 
