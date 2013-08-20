using System.Collections.Generic;
using System.Web;

using PayPal.Permissions;
using PayPal.Permissions.Model;

using System.Configuration;
namespace PermissionsSampleApp
{
    /// <summary>
    /// Summary description for PermissionsHandler
    /// </summary>
    public class PermissionsHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //Selenium Test Case
            context.Response.ContentType = "text/html";

            string strCall = context.Request.Params["PermissionsBtn"];

            if (strCall.Equals("RequestPermissions"))
            {
                RequestPermissions(context);
            }
            else if (strCall.Equals("GetAccessToken"))
            {
                GetAccessToken(context);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


        private void RequestPermissions(HttpContext context)
        {
            RequestPermissionsRequest rp = new RequestPermissionsRequest();
            rp.scope = new List<string>();

            // (Required) At least 1 of the following permission categories:
            //EXPRESS_CHECKOUT - Express Checkout
            //DIRECT_PAYMENT - Direct payment by debit or credit card
            //SETTLEMENT_CONSOLIDATION - Settlement consolidation
            //SETTLEMENT_REPORTING - Settlement reporting
            //AUTH_CAPTURE - Payment authorization and capture
            //MOBILE_CHECKOUT - Mobile checkout
            //BILLING_AGREEMENT - Billing agreements
            //REFERENCE_TRANSACTION - Reference transactions
            //AIR_TRAVEL - Express Checkout for UTAP
            //MASS_PAY - Mass pay
            //TRANSACTION_DETAILS - Transaction details
            //TRANSACTION_SEARCH - Transaction search
            //RECURRING_PAYMENTS - Recurring payments
            //ACCOUNT_BALANCE - Account balance
            //ENCRYPTED_WEBSITE_PAYMENTS - Encrypted website payments
            //REFUND - Refunds
            //NON_REFERENCED_CREDIT - Non-referenced credit
            //BUTTON_MANAGER - Button Manager
            //MANAGE_PENDING_TRANSACTION_STATUS includes ManagePendingTransactionStatus
            //RECURRING_PAYMENT_REPORT - Reporting for recurring payments
            //EXTENDED_PRO_PROCESSING_REPORT - Extended Pro processing
            //EXCEPTION_PROCESSING_REPORT - Exception processing
            //ACCOUNT_MANAGEMENT_PERMISSION - Account Management Permission (MAM)
            //ACCESS_BASIC_PERSONAL_DATA - User attributes
            //ACCESS_ADVANCED_PERSONAL_DATA - User attributes
            //INVOICING - Invoicing
            string[] scopes = context.Request.Form.GetValues("api");

            for (int i = 0; i < scopes.Length; i++)
                rp.scope.Add(scopes[i]);

            //(Required) Your callback function that specifies actions to 
            // take after the account holder grants or denies the request. 
            rp.callback = context.Request.Params["callback"];

            // (Required) RFC 3066 language in which error messages are returned; 
            // by default it is en_US, which is the only language currently supported.
            rp.requestEnvelope = new RequestEnvelope("en_US");
            RequestPermissionsResponse rpr = null;

            try
            {
                // ## Creating service wrapper object
                // Creating service wrapper object to make API call   
                // Configuration map containing signature credentials and other required configuration.
                // For a full list of configuration parameters refer in wiki page 
                // [https://github.com/paypal/sdk-core-dotnet/wiki/SDK-Configuration-Parameters]
                PermissionsService service = new PermissionsService(Configuration.GetAcctAndConfig());

                rpr = service.RequestPermissions(rp);
                context.Response.Write("<html><body><textarea rows=30 cols=80>");
                ObjectDumper.Write(rpr, 5, context.Response.Output);
                context.Response.Write("</textarea></body></html>");

                string red = "<br>";
                red = red + "<a href=";
                red = red + ConfigurationManager.AppSettings["PAYPAL_REDIRECT_URL"] + "_grant-permission&request_token=" + rpr.token;
                red = red + ">Redirect URL (Click to redirect)</a><br>";
                context.Response.Write(red);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
            }
        }

        private void GetAccessToken(HttpContext context)
        {
            GetAccessTokenRequest gat = new GetAccessTokenRequest();

            // (Required) The request token from the response to RequestPermissions. 
            string token = context.Request.Params["txtrequest_token"];

            // (Required) The verification code returned in the redirect from PayPal to the return URL. 
            string verifier = context.Request.Params["txtverification_code"];

            gat.token = token;
            gat.verifier = verifier;

            // (Required) RFC 3066 language in which error messages are returned; 
            // by default it is en_US, which is the only language currently supported.
            gat.requestEnvelope = new RequestEnvelope("en_US");
            GetAccessTokenResponse gats = null;

            try
            {
                // ## Creating service wrapper object
                // Creating service wrapper object to make API call   
                // Configuration map containing signature credentials and other required configuration.
                // For a full list of configuration parameters refer in wiki page 
                // [https://github.com/paypal/sdk-core-dotnet/wiki/SDK-Configuration-Parameters]
                PermissionsService service = new PermissionsService(Configuration.GetAcctAndConfig());

                gats = service.GetAccessToken(gat);
                context.Response.Write("<html><body><textarea rows=30 cols=80>");
                ObjectDumper.Write(gats, 5, context.Response.Output);
                context.Response.Write("</textarea></br>");

                //Selenium Test Case
                context.Response.Write("</br>Acknowledgement: ");
                context.Response.Write("<div id = '");
                context.Response.Write("Acknowledgement");
                context.Response.Write("'>");
                context.Response.Write(gats.responseEnvelope.ack);
                context.Response.Write("</div>");

                context.Response.Write("</br>Request token: ");
                context.Response.Write("<div id = '");
                context.Response.Write("Request token");
                context.Response.Write("'>");
                context.Response.Write(context.Request.Params["txtrequest_token"]);
                context.Response.Write("</div>");

                context.Response.Write("</br>Verification code: ");
                context.Response.Write("<div id = '");
                context.Response.Write("Verification code");
                context.Response.Write("'>");
                context.Response.Write(context.Request.Params["txtverification_code"]);
                context.Response.Write("</div>");
                                
                context.Response.Write("</br>token: ");
                context.Response.Write("<div id = '");
                context.Response.Write("token");
                context.Response.Write("'>");
                context.Response.Write(gats.token);          
                context.Response.Write("</div>");

                context.Response.Write("</br>tokenSecret: ");
                context.Response.Write("<div id = '");
                context.Response.Write("tokenSecret");
                context.Response.Write("'>");
                context.Response.Write(gats.tokenSecret);
                context.Response.Write("</div>");
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
            }
        }
    }
}
