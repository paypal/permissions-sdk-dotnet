
# PayPal Permissions SDK

The PayPal Permissions API enables you to request and obtain authorization to make API calls and take action on behalf of your customers. The PayPal Permissions SDK provides the following API Operations - 

   * GetPermissions - Use the GetPermissons API operation to obtain the permissions associated with an access token.
   * RequestPermissions - Use the RequestPermissions API operation to request permissions to execute API operations on a PayPal account holder’s behalf.
   * CancelPermissions - Use the CancelPermissions API operation to cancel access to a set of permissions.
   * GetBasicPersonalData & GetAdvancedPersonalData  - Use these operations to retrieve the attributes for which you have been granted permissions for.

## Prerequisites

   * Visual Studio 2005 or higher
   * .NET Framework 2.0 or higher
   * (Optional) NuGet 2.2 for managing dependencies

## Using the SDK

   To use the SDK in your application, you must
   
   * Get the PayPalPermissionsSDK dll via NuGet or from the download bundle and add references to the PayPalPermissionsSDK and PayPalCoreSDK libraries.
   * Configure your app as detailed in the configuration section.
   
## SDK Configuration

  An application that uses the PayPal SDKs can be configured in one of two ways -
  
  * Using the Web.Config / App.Config files.

	```html
    <configSections>
	<section name="paypal" type="PayPal.Manager.SDKConfigHandler, PayPalCoreSDK" />
	<section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
	</configSections>
	<!-- PayPal SDK config -->
	<paypal>
	<settings>
	    <add name="mode" value="sandbox"/>	    
	    <add name="connectionTimeout" value="30000"/>
	    .....
	</settings>
	<accounts>
	    <account apiUsername="jb-us-seller_api1.paypal.com" apiPassword="..." apiSignature="..." applicationId='...' />
	    <account apiUsername="enduser_biz_api1.gmail.com" apiPassword="..." apiCertificate="..." privateKeyPassword="..." applicationId='...' />
	</accounts>
	</paypal>
    ```
  
  * Or, by dynamically passing in a dictionary (that you can load from a database or as suits your needs).

    ```csharp
    Dictionary<string, string> config = new Dictionary<string, string>();
    config.Add("mode", "sandbox");
    config.Add("account1.apiUsername", "jb-us-seller_api1.paypal.com");
    config.Add("account1.apiPassword", "...");
    config.Add("account1.apiSignature", "...");
    config.Add("account1.applicationId", "...");
    
    PermissionsService service = new PermissionsService(config);
    ```

	You can refer full list of configuration parameters in [wiki](https://github.com/paypal/sdk-core-dotnet/wiki/SDK-Configuration-Parameters) page.
	
## Links

   * [Installing NuGet in Visual Studio 2005 & 2008] (https://github.com/paypal/sdk-core-dotnet/wiki/Using-Nuget-in-Visual-Studio-2005-&-2008)
   * [Installing NuGet in Visual Studio 2010 & 2012] (https://github.com/paypal/sdk-core-dotnet/wiki/Using-Nuget-in-Visual-Studio-2010-&-2012)
