using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Presenters.ViewInterfaces;
using CWM.Core.Domain;
using CWM.Core.Security;
using IdeaSeed.Core;
using System.Configuration;
using CWM.Services;
using CWM.Core;

namespace CWM.Presenters
{
    public class HomeBlogListPresenter : Presenter
    {
        IHomeBlogListView _view;

        public HomeBlogListPresenter(IHomeBlogListView view, ISessionProvider session)
            : base(view, session)
        {
            _view = base.GetView<IHomeBlogListView>();
            _view.InitView += new EventHandler(_view_InitView);
            _view.LoadView += new EventHandler(_view_LoadView);
            _view.UnloadView += new EventHandler(_view_UnloadView);
        }

        void _view_UnloadView(object sender, EventArgs e)
        {

        }

        void _view_LoadView(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            var list = ApplicationContext.HomeBlogListData;
            
            sb.Append("<div id='mainContent' class='grid_9'>");
            foreach (var item in list)
            {
                var url = SecurityContextManager.Current.BaseURL + "/Blog/";
                switch (item.PostType)
                {
                    case (int)BlogPostType.ARTS:
                        url += "Arts/";
                        break;
                    case (int)BlogPostType.BUSINESS:
                        url += "Business/";
                        break;
                    case (int)BlogPostType.CITY:
                        url += "City/";
                        break;
                }
                url += item.Title.Replace(" ", "-");

                string fb = "<iframe src='http://www.facebook.com/widgets/like.php?href=" + url + "&amp;layout=standard&amp;show_faces=true&amp;width=300&amp;action=like&amp;font=verdana&amp;colorscheme=light' scrolling='no' frameborder='0' style='border:none; width:300px; height:25px; '></iframe>";
                if (item.ID == list[0].ID)
                {

                    sb.Append("<div  class='upperpost'><div class='post postLrg'>");
                    sb.Append("<a href='");
                    sb.Append(url);
                    sb.Append("' title='");
                    sb.Append(item.Title);
                    sb.Append("'><h1>");
                    sb.Append(item.Title);
                    sb.Append("</h1></a><a href='");
                    sb.Append(url);
                    sb.Append("' title='");
                    sb.Append(item.Title);
                    sb.Append("'><img src='");
                    string blogImage = "BLOGIMAGE_" + item.PostType.ToString();
                    sb.Append(ConfigurationManager.AppSettings[blogImage]);
                    sb.Append("' alt'");
                    sb.Append(item.Title);
                    sb.Append("' /></a><div class='meta'><span class='user'>");
                    sb.Append(item.BlogUser.FirstName);
                    sb.Append(" ");
                    sb.Append(item.BlogUser.LastName);
                    sb.Append("</span><span class='date'>");
                    sb.Append(item.StartDate.ToShortDateString());
                    sb.Append("</span><span class='comments'>");
                    sb.Append(fb);
                    sb.Append("</span></div><br />");
                    if (item.BlogContent.Length > 315)
                    {
                        sb.Append(item.BlogContent.Substring(0, 315));
                        sb.Append("...");
                    }
                    else
                    {
                        sb.Append(item.BlogContent);
                    }

                    sb.Append("<br /> <a href='");
                    sb.Append(url);
                    sb.Append("' title='");
                    sb.Append(item.Title);
                    sb.Append("'><h2>ReadMore</h2></a></div></div>");
                }
                else
                {

                    sb.Append("<div  class='lowerpost'><div class='post postLrg'>");
                    sb.Append("<a href='");
                    sb.Append(url);
                    sb.Append("' title='");
                    sb.Append(item.Title);
                    sb.Append("'><h1>");
                    sb.Append(item.Title);
                    sb.Append("</h1></a><a href='");
                    sb.Append(url);
                    sb.Append("' title='");
                    sb.Append(item.Title);
                    sb.Append("'><img src='");
                    string blogImage = "BLOGIMAGE_" + item.PostType.ToString();
                    sb.Append(ConfigurationManager.AppSettings[blogImage]);
                    sb.Append("' alt'");
                    sb.Append(item.Title);
                    sb.Append("' /></a><div class='meta'><span class='user'>");
                    sb.Append(item.BlogUser.FirstName);
                    sb.Append(" ");
                    sb.Append(item.BlogUser.LastName);
                    sb.Append("</span><span class='date'>");
                    sb.Append(item.StartDate.ToShortDateString());
                    sb.Append("</span><span class='comments'>");
                    sb.Append(fb);
                    sb.Append("</span></div><br />");
                    if (item.BlogContent.Length > 315)
                    {
                        sb.Append(item.BlogContent.Substring(0, 315));
                        sb.Append("...");
                    }
                    else
                    {
                        sb.Append(item.BlogContent);
                    }

                    sb.Append("<br /> <a href='");
                    sb.Append(url);
                    sb.Append("' title='");
                    sb.Append(item.Title);
                    sb.Append("'><h2>ReadMore</h2></a></div></div>");
                }
            }
            sb.Append("</div>");
            _view.BlogHTML = sb.ToString();
        }

        void _view_InitView(object sender, EventArgs e)
        {

        }
    }
}
