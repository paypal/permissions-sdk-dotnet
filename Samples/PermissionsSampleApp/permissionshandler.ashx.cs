using System;
using System.Collections.Generic;
using System.Web;

using PayPal.Util;
using PayPal;
using PayPal.Permissions;
using PayPal.Permissions.Model;

using PayPal.Authentication;
using PayPal.Exception;
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
            context.Response.ContentType = "text/plain";

            String strCall = context.Request.Params["PermissionsBtn"];

             if(strCall.Equals("RequestPermissions")){
                RequestPermissions(context);
            }else if(strCall.Equals("GetAccessToken")){
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
          string[] scopes= context.Request.Form.GetValues("api");
          
            for (int i=0;i<scopes.Length;i++)
            rp.scope.Add(scopes[i]);

            
            rp.callback = context.Request.Params["callback"];
            rp.requestEnvelope = new RequestEnvelope("en_US");
           RequestPermissionsResponse rpr = null;

            try
            {
               PermissionsService service = new PermissionsService();                
                rpr = service.RequestPermissions(rp);
                context.Response.Write("<html><body><textarea rows=30 cols=80>");
                ObjectDumper.Write(rpr, 5, context.Response.Output);               
                context.Response.Write("</textarea></body></html>");

                context.Items["responseObject"] = rpr;
                context.Items["responsePayload"] = service.getLastResponse();

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

            String token = context.Request.Params["txtrequest_token"];
            String verifier = context.Request.Params["txtverification_code"];

            gat.token = token;
            gat.verifier = verifier;


            gat.requestEnvelope = new RequestEnvelope("en_US");
           GetAccessTokenResponse gats = null;

            try
            {
                PermissionsService service = new PermissionsService();
                gats = service.GetAccessToken(gat);                
                context.Response.Write("<html><body><textarea rows=30 cols=80>");
                ObjectDumper.Write(gats, 5, context.Response.Output);
                context.Response.Write("</textarea></body></html>");

                context.Items["responseObject"] = gats;
                context.Items["responsePayload"] = service.getLastResponse();
       
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
            }

        }



        
    }
}