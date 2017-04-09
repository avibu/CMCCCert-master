using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WindowsIdentity identity = HttpContext.Current.Request.LogonUserIdentity;
            string userName = identity.Name;
           string[] test =userName.Split('\\');
            userName = test[1];
            username.Text = "Hello " +userName;

        }
    }
}