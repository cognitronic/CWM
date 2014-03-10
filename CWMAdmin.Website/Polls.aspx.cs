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
using Telerik.Charting;
using CWMAdmin.Web.Utils;
using CWM.Core.Security;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CWMAdmin.Website
{
    public partial class Polls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPolls(true);
            }
        }

        protected void ItemDataBound(object o, GridItemEventArgs e)
        {
            if (e.Item is GridDataItem)
            {
                GridDataItem item = e.Item as GridDataItem;
                RadChart chart = item["ChartResults"].FindControl("rcResults") as RadChart;
                var lb = item["EditColumn"].FindControl("lbEdit") as LinkButton;

                LoadResults(Convert.ToInt32(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString()), chart);
            }
        }

        protected void NeedDataSource(object o, GridNeedDataSourceEventArgs e)
        {
            LoadPolls(false);
        }

        protected void ChartItemDataBound(object o, ChartItemDataBoundEventArgs e)
        {
            e.SeriesItem.Name = ((DataRowView)e.DataItem)["Name"].ToString();
        }



        protected void ItemCommand(object o, GridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case RadGrid.InitInsertCommandName:
                    Response.Redirect("/Poll.aspx");
                    break;
                case RadGrid.EditCommandName:
                    Response.Redirect("/Poll.aspx?id=" + e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString());
                    break;
                case RadGrid.DeleteCommandName:
                    var img = new PollServices().GetByID(Convert.ToInt32(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString()));
                    new PollServices().Delete(img);
                    //LoadLinks(true);
                    break;
            }
        }

        private void LoadPolls(bool binddata)
        {
            rgPoll.DataSource = new PollServices().GetAll();
            if (binddata)
                rgPoll.DataBind();
        }

        protected SqlConnection dbCon;
        private void LoadResults(int pollID, RadChart chart)
        {
            var sql = @"SELECT COUNT(PollResult.PollOptionID) AS cnt, PollOption.Name
FROM  PollResult INNER JOIN
               PollOption ON PollResult.PollOptionID = PollOption.ID
WHERE (PollResult.PollID = " + pollID.ToString() + @")
GROUP BY PollResult.PollOptionID, PollOption.Name";
            var ds = IdeaSeed.Core.Data.DataUtils.ExecuteSQLStatement(ConfigurationManager.ConnectionStrings["CWM.ConnectionString"].ConnectionString, sql, ConfigurationManager.AppSettings["DBUSER"], ConfigurationManager.AppSettings["DBPWD"]);
            
            chart.DataSource = ds.Tables[0];
            chart.PlotArea.Chart.Legend.Visible = false;

            chart.DataBind();
        }

    }
}

