<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestPermissions.aspx.cs" Inherits="PermissionsSampleApp.RequestPermissions" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Permissions</title>
   
</head>
<body>
   
    <h2>RequestPermissions API Test Page</h2>
 <form id="form1" runat="server" action="PermissionsHandler.ashx">
  <%string url = Request.Url.Scheme + "://" + Request.Url.Host + ":" + Request.Url.Port + Request.ApplicationPath;
      string returnURL = url + (Request.ApplicationPath.EndsWith("/") ? "" : "/") + "GetAccessToken.aspx"; %>
		<div class="params">
			<div class="param_name">CallBack</div>
			<div class="param_value">
				<input type="text" id="callback" name="callback" size="60"
					value="<%=returnURL%>" /><br />
			</div>
		</div>
		<div class="params">
			<div class="param_name">Scope</div>
			<div class="param_value">
				<input type="checkbox" name="api" value="EXPRESS_CHECKOUT" />EXPRESS_CHECKOUT<br />
				<input type="checkbox" name="api" value="DIRECT_PAYMENT" />DIRECT_PAYMENT<br />
				<input type="checkbox" name="api" value="AUTH_CAPTURE" />AUTH_CAPTURE<br />
				<input type="checkbox" name="api" value="AIR_TRAVEL" />AIR_TRAVEL<br />
				<input type="checkbox" name="api" value="TRANSACTION_SEARCH" />TRANSACTION_SEARCH<br />
				<input type="checkbox" name="api" value="RECURRING_PAYMENTS" />RECURRING_PAYMENTS<br />
				<input type="checkbox" name="api" value="ACCOUNT_BALANCE" />ACCOUNT_BALANCE<br />
				<input type="checkbox" name="api" value="ENCRYPTED_WEBSITE_PAYMENTS" />ENCRYPTED_WEBSITE_PAYMENTS<br />
				<input type="checkbox" name="api" value="REFUND" /> REFUND<br /> <input
					type="checkbox" name="api" value="BILLING_AGREEMENT" />BILLING_AGREEMENT<br />
				<input type="checkbox" name="api" value="REFERENCE_TRANSACTION" />REFERENCE_TRANSACTION<br />
				<input type="checkbox" name="api" value="MASS_PAY" />MASS_PAY<br />
				<input type="checkbox" name="api" value="TRANSACTION_DETAILS" />TRANSACTION_DETAILS<br />
				<input type="checkbox" name="api" value="NON_REFERENCED_CREDIT" />NON_REFERENCED_CREDIT<br />
				<input type="checkbox" name="api" value="SETTLEMENT_CONSOLIDATION" />SETTLEMENT_CONSOLIDATION<br />
				<input type="checkbox" name="api" value="SETTLEMENT_REPORTING" />SETTLEMENT_REPORTING<br />
				<input type="checkbox" name="api" value="BUTTON_MANAGER" />BUTTON_MANAGER<br />
				<input type="checkbox" name="api"
					value="MANAGE_PENDING_TRANSACTION_STATUS" />MANAGE_PENDING_TRANSACTION_STATUS<br />
				<input type="checkbox" name="api" value="RECURRING_PAYMENT_REPORT" />RECURRING_PAYMENT_REPORT<br />
				<input type="checkbox" name="api"
					value="EXTENDED_PRO_PROCESSING_REPORT" />EXTENDED_PRO_PROCESSING_REPORT<br />
				<input type="checkbox" name="api"
					value="EXCEPTION_PROCESSING_REPORT" />EXCEPTION_PROCESSING_REPORT<br />
				<input type="checkbox" name="api"
					value="ACCOUNT_MANAGEMENT_PERMISSION" />ACCOUNT_MANAGEMENT_PERMISSION<br />
				<input type="checkbox" name="api" value="INVOICING" />INVOICING<br />
			</div>
		</div>
		<input type="submit" name="PermissionsBtn" value="RequestPermissions" />
		<br /> 
	
    </form>
</body>
</html>
