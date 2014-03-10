using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CWM.Web.Bases;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Configuration;
using IdeaSeed.Core.Mail;
using System.Web.UI.HtmlControls;
using IdeaSeed.Web.UI;
using CWM.Services;
using CampaignManager.Data.Repositories;
using CampaignManager.Core.Domain;

namespace CWM.Website.MasterPages
{
    public partial class Default : BaseMasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Views.PrimaryNavView PrimaryNavView
        {
            get
            {
                return primaryNavView;
            }
        }

        protected void NewsletterClicked(object o, EventArgs e)
        {
            try
            {
                SaveNewSubscriber(tbEmail.Text);
                tbEmail.Text = "";
                lblMessage.Visible = true;
                lblMessage.Text = "<font color='green'>Thanks!!!</font>";
                try
                {
                    var sb = new StringBuilder();
                    sb.Append("<html><body><a href='www.mydatapath.com'><img src='http://cwm.mydatapath.com/img/logo/logoMain_02.png' alt='logo' /></a><br /><br />Thank you for registering with our newsletter!!");
                    var messageSent = EmailUtils.SendEmail(tbEmail.Text.Trim(), "Newsletter@modesto.com", "", ConfigurationManager.AppSettings["NEWSLETTER_EMAIL_RECIPIENTS"], "Thank You For Registering With Modesto.com!", sb.ToString().Trim(), false, "");
                }
                catch (Exception exc)
                { 
                    
                }
            }
            catch (Exception ex)
            {
                if (ex.GetBaseException().GetType() == typeof(SqlException))
                {
                    lblMessage.Visible = true;
                    lblMessage.Text = "<font color='red'>Already Registered!!!</font>";
                }
                else
                    lblMessage.Text = "<font color='red'>Try Back Later.</font>";
            }
        }

        private void SaveNewSubscriber(string email)
        {
            var s = new SubscriberRepository().GetByEmail(email);
            if (s == null)
            {
                s = new Subscriber();
                s.Email = email;
                s.IsActive = true;
                new SubscriberRepository().Save(s);

                var t = new CampaignManager.Core.Domain.SubscriberCampaignTag();
                t.CampaignTagID = Convert.ToInt16(ConfigurationManager.AppSettings["ALLSUBSCRIBERSTAGID"]);
                t.SubscriberID = s.ID;
                new CampaignManager.Data.Repositories.SubscriberCampaignTagRepository().Save(t);
            }
        }

        public ContentPlaceHolder MainContent
        {
            get
            {
                return cpMainContent;
            }
        }
    }
}