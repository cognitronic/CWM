using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using IdeaSeed.Core;
using CWM.Services;
using CWM.Core.Domain;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using CWMAdmin.Web.Bases;
using CWMAdmin.Web.Utils;
using CWM.Core.Security;

namespace CWMAdmin.Website
{
    public partial class Login : NoSecurityBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginClicked(object o, EventArgs e)
        {
            string userName = tbUsername.Text;
            string password = tbPassword.Text;

            var response = new SecurityServices().AuthenticateUser(userName, password, "", SecurityContextManager.Current);
            if (response.IsAuthenticated)
            {
                if (((CWM.Core.Domain.User)SecurityContextManager.Current.CurrentUser).AccessLevel < 60)
                {
                    Response.Redirect("/Blog.aspx");
                }
                Response.Redirect("/Default.aspx");
            }
            else
            {
                lblLoginMessage.Visible = true;
                lblLoginMessage.Text = "Invalid username or password.<br/>Please try again.";
            }
        }

        protected void ForgotPasswordClicked(object o, EventArgs e)
        {
            
        }
    }
}