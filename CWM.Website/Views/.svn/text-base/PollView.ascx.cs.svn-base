using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CWM.Presenters.ViewInterfaces;
using CWM.Presenters;
using CWM.Core.Domain;
using CWM.Core.Security;
using IdeaSeed.Core;
using CWM.Web.Bases;
using CWM.Services;
using CWM.Core;

namespace CWM.Website.Views
{
    [PresenterType(typeof(PollPresenter))]
    public partial class PollView : BaseWebUserControl, IPollView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.SelfRegister(this);
            if (this.LoadView != null)
            {
                this.LoadView(this, EventArgs.Empty);
            }
            if (!IsPostBack)
            {
                LoadPoll(); 
            }
        }
        public new event EventHandler LoadView;
        #region IBannerImagesView Members

        public Poll CurrentPoll
        {
            get;
            set;
        }

        public void LoadPoll()
        {
            lblQuestion.Text = CurrentPoll.Question;
            rb1.Items.Clear();
            foreach (var item in CurrentPoll.Options)
            {
                var li = new ListItem(item.Name, item.ID.ToString());
                li.Attributes.Add("class", "pollitem");
                rb1.Items.Add(li);
            }
        }

        protected void SubmitAnswerClicked(object o, EventArgs e)
        {
            var result = new PollResult();
            result.PollID = CurrentPoll.ID;
            if (!string.IsNullOrEmpty(rb1.SelectedValue))
            {
                result.PollOptionID = Convert.ToInt32(rb1.SelectedValue);
            }
            new PollResultServices().Save(result);
            lbSubmitAnswer.Visible = false;
            lblPollMessage.Text = "<strong>Thank you for your feedback!</strong>";
            LoadPoll();
        }

        #endregion
    }
}