using System;
using System.Collections.Generic;
using System.Xml;
using PayPal;
using PayPal.Authentication;
using PayPal.Util;
using PayPal.Manager;
using PayPal.NVP;
using PayPal.Permissions.Model;

namespace PayPal.Permissions 
{
	public partial class PermissionsService : BasePayPalService 
	{

		/// <summary>
		/// Service Version
		/// </summary>
		private const string ServiceVersion = "";

		/// <summary>
		/// Service Name
		/// </summary>
		private const string ServiceName = "Permissions";
		
		/// <summary>
		/// SDK Name
		/// </summary>
		private const string SDKName = "permissions-dotnet-sdk";
	
		/// <summary>
		/// SDK Version
		/// </summary>
		private const string SDKVersion = "2.2.100";

		/// <summary>
		/// Default constructor for loading configuration from *.Config file
		/// </summary>
		public PermissionsService() : base() {}
		
		/// <summary>
		/// constructor for passing in a dynamic configuration object
		/// </summary>
		public PermissionsService(Dictionary<string, string> config) : base(config) {}
		

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="requestPermissionsRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public RequestPermissionsResponse RequestPermissions(RequestPermissionsRequest requestPermissionsRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, requestPermissionsRequest.ToNVPString(string.Empty), ServiceName, "RequestPermissions", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Permissions";
			
			NVPUtil util = new NVPUtil();
			return RequestPermissionsResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="requestPermissionsRequest"></param>
	 	
	 	public RequestPermissionsResponse RequestPermissions(RequestPermissionsRequest requestPermissionsRequest)
	 	{
	 		return RequestPermissions(requestPermissionsRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="requestPermissionsRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public RequestPermissionsResponse RequestPermissions(RequestPermissionsRequest requestPermissionsRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, requestPermissionsRequest.ToNVPString(string.Empty), ServiceName, "RequestPermissions", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Permissions";

			NVPUtil util = new NVPUtil();
			return RequestPermissionsResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="getAccessTokenRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest getAccessTokenRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, getAccessTokenRequest.ToNVPString(string.Empty), ServiceName, "GetAccessToken", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Permissions";
			
			NVPUtil util = new NVPUtil();
			return GetAccessTokenResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="getAccessTokenRequest"></param>
	 	
	 	public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest getAccessTokenRequest)
	 	{
	 		return GetAccessToken(getAccessTokenRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="getAccessTokenRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest getAccessTokenRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, getAccessTokenRequest.ToNVPString(string.Empty), ServiceName, "GetAccessToken", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Permissions";

			NVPUtil util = new NVPUtil();
			return GetAccessTokenResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="getPermissionsRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public GetPermissionsResponse GetPermissions(GetPermissionsRequest getPermissionsRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, getPermissionsRequest.ToNVPString(string.Empty), ServiceName, "GetPermissions", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Permissions";
			
			NVPUtil util = new NVPUtil();
			return GetPermissionsResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="getPermissionsRequest"></param>
	 	
	 	public GetPermissionsResponse GetPermissions(GetPermissionsRequest getPermissionsRequest)
	 	{
	 		return GetPermissions(getPermissionsRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="getPermissionsRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public GetPermissionsResponse GetPermissions(GetPermissionsRequest getPermissionsRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, getPermissionsRequest.ToNVPString(string.Empty), ServiceName, "GetPermissions", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Permissions";

			NVPUtil util = new NVPUtil();
			return GetPermissionsResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="cancelPermissionsRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public CancelPermissionsResponse CancelPermissions(CancelPermissionsRequest cancelPermissionsRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, cancelPermissionsRequest.ToNVPString(string.Empty), ServiceName, "CancelPermissions", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Permissions";
			
			NVPUtil util = new NVPUtil();
			return CancelPermissionsResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="cancelPermissionsRequest"></param>
	 	
	 	public CancelPermissionsResponse CancelPermissions(CancelPermissionsRequest cancelPermissionsRequest)
	 	{
	 		return CancelPermissions(cancelPermissionsRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="cancelPermissionsRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public CancelPermissionsResponse CancelPermissions(CancelPermissionsRequest cancelPermissionsRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, cancelPermissionsRequest.ToNVPString(string.Empty), ServiceName, "CancelPermissions", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Permissions";

			NVPUtil util = new NVPUtil();
			return CancelPermissionsResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="getBasicPersonalDataRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public GetBasicPersonalDataResponse GetBasicPersonalData(GetBasicPersonalDataRequest getBasicPersonalDataRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, getBasicPersonalDataRequest.ToNVPString(string.Empty), ServiceName, "GetBasicPersonalData", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Permissions";
			
			NVPUtil util = new NVPUtil();
			return GetBasicPersonalDataResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="getBasicPersonalDataRequest"></param>
	 	
	 	public GetBasicPersonalDataResponse GetBasicPersonalData(GetBasicPersonalDataRequest getBasicPersonalDataRequest)
	 	{
	 		return GetBasicPersonalData(getBasicPersonalDataRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="getBasicPersonalDataRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public GetBasicPersonalDataResponse GetBasicPersonalData(GetBasicPersonalDataRequest getBasicPersonalDataRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, getBasicPersonalDataRequest.ToNVPString(string.Empty), ServiceName, "GetBasicPersonalData", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Permissions";

			NVPUtil util = new NVPUtil();
			return GetBasicPersonalDataResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="getAdvancedPersonalDataRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public GetAdvancedPersonalDataResponse GetAdvancedPersonalData(GetAdvancedPersonalDataRequest getAdvancedPersonalDataRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, getAdvancedPersonalDataRequest.ToNVPString(string.Empty), ServiceName, "GetAdvancedPersonalData", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Permissions";
			
			NVPUtil util = new NVPUtil();
			return GetAdvancedPersonalDataResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="getAdvancedPersonalDataRequest"></param>
	 	
	 	public GetAdvancedPersonalDataResponse GetAdvancedPersonalData(GetAdvancedPersonalDataRequest getAdvancedPersonalDataRequest)
	 	{
	 		return GetAdvancedPersonalData(getAdvancedPersonalDataRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="getAdvancedPersonalDataRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public GetAdvancedPersonalDataResponse GetAdvancedPersonalData(GetAdvancedPersonalDataRequest getAdvancedPersonalDataRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, getAdvancedPersonalDataRequest.ToNVPString(string.Empty), ServiceName, "GetAdvancedPersonalData", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "Permissions";

			NVPUtil util = new NVPUtil();
			return GetAdvancedPersonalDataResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	}
}
