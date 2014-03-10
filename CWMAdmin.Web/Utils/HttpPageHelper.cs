using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Core.Domain;
using IdeaSeed.Core;
using IdeaSeed.Web;

namespace CWMAdmin.Web.Utils
{
    public class HttpPageHelper
    {
        public static Page CurrentPage
        {
            get { return HttpContextHelper.Get<Page>("SQ_CURRENT_PAGE"); }
            set { HttpContextHelper.Set("SQ_CURRENT_PAGE", value); }
        }

        public static bool IsValidRequest
        {
            get { return HttpContextHelper.Get<bool>("SQ_IS_VALID_REQUEST"); }
            set { HttpContextHelper.Set("SQ_IS_VALID_REQUEST", value); }
        }

        public static IBaseItem CurrentItem
        {
            get { return HttpContextHelper.Get<IBaseItem>("SQ_CURRENTITEM"); }
            set { HttpContextHelper.Set("SQ_CURRENTITEM", value); }
        }

        public static User CurrentUser
        {
            get { return HttpContextHelper.Get<User>("SQ_CURRENTUSER"); }
            set { HttpContextHelper.Set("SQ_CURRENTUSER", value); }
        }
    }
}
