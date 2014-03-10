using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CWM.Core.Security;

namespace CWMAdmin.Website.MasterPages
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (SecurityContextManager.Current != null && SecurityContextManager.Current.CurrentUser != null && SecurityContextManager.Current.CurrentUser.ID > 0)
            {
                lbLogout.Visible = true;
            }
            else
            {
                lbLogout.Visible = false;
            }
        }

        protected void LogoutClicked(object o, EventArgs e)
        {
            SecurityContextManager.Current.SignOutUser();
        }
    }
}