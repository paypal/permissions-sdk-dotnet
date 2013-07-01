using System;

namespace PermissionsSampleApp
{
    public partial class GetAccessToken : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["request_token"] != null)
            {
                this.txtrequest_token.Value = Request.QueryString["request_token"].ToString();
                this.txtverification_code.Value = Request.QueryString["verification_code"].ToString();
            }
        }
    }
}
