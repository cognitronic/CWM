using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using CWM.Core.Domain;
using System.Collections.Generic;
using System.Web.Routing;
using CWM.Services;

namespace CWM.Web.Routing
{
    public class RouteBuilder
    {
        public RouteCollection Routes { get; private set; }
        public RouteBuilder(RouteCollection routes)
        {
            Routes = routes;
        }

        public void Run()
        {

            Route defaultRoute = new Route("Home", new DefaultRouteHandler("Home"));
            Routes.Add(defaultRoute);

            BuildResidentsRoutes();
            BuildVisitorRoutes();
            BuildBusinessRoutes();
            BuildMediaRoutes();
            BuildBlogRoutes();

            //defaultRoute = new Route("", new DefaultRouteHandler("Home"));
            //Routes.Add(defaultRoute);

        }

        public void BuildResidentsRoutes()
        {
            Route route = new Route("Faith-Based-Communities", new DefaultRouteHandler("Faith Based Communities"));
            Routes.Add(route);

            route = new Route("Civic-Groups", new DefaultRouteHandler("Civic Groups"));
            Routes.Add(route);
            route = new Route("Community-Calendar", new DefaultRouteHandler("Community Calendar"));
            Routes.Add(route);
            route = new Route("Local-News", new DefaultRouteHandler("Local News"));
            Routes.Add(route);
            route = new Route("Local-Government", new DefaultRouteHandler("Local Government"));
            Routes.Add(route);
            route = new Route("History-Of-Modesto", new DefaultRouteHandler("History of Modesto"));
            Routes.Add(route);
        }

        public void BuildVisitorRoutes()
        {
            Route route = new Route("Attractions", new DefaultRouteHandler("Attractions"));
            Routes.Add(route);

            route = new Route("American-Graffiti", new DefaultRouteHandler("American Graffiti"));
            Routes.Add(route);
            route = new Route("Arts-Entertainment", new DefaultRouteHandler("Arts Entertainment"));
            Routes.Add(route);
            route = new Route("Nearby-Destinations", new DefaultRouteHandler("Nearby Destinations"));
            Routes.Add(route);
            route = new Route("Modesto-Real-Estate", new DefaultRouteHandler("Modesto Real Estate"));
            Routes.Add(route);
        }

        public void BuildBusinessRoutes()
        {
            Route route = new Route("Agriculture-Agribusiness", new DefaultRouteHandler("Agriculture Agribusiness"));
            Routes.Add(route);

            route = new Route("Business-Directory", new DefaultRouteHandler("Business Directory"));
            Routes.Add(route);
            route = new Route("Support-For-Business", new DefaultRouteHandler("Support For Business"));
            Routes.Add(route);
            route = new Route("Education-Opportunities", new DefaultRouteHandler("Education Opportunities"));
            Routes.Add(route);
        }

        public void BuildMediaRoutes()
        {
            Route route = new Route("Some-Images", new DefaultRouteHandler("Some Images"));
            Routes.Add(route);

            route = new Route("Maybe-Videos", new DefaultRouteHandler("Maybe Videos"));
            Routes.Add(route);
            route = new Route("Events", new DefaultRouteHandler("Events"));
            Routes.Add(route);
            route = new Route("Our-Community", new DefaultRouteHandler("Our Community"));
            Routes.Add(route);
        }

        public void BuildBlogRoutes()
        {
            Route route = new Route("Blog/Arts/{title}", new BlogSingleRouteHandler("BlogSingle"));
            route.Constraints = new RouteValueDictionary { { "title", @"^\D+" } };
            RouteValueDictionary routeValues = new RouteValueDictionary();
            routeValues.Add("BlogType", 1);
            route.DataTokens = routeValues;
            Routes.Add(route);

            route = new Route("Blog/Business/{title}", new BlogSingleRouteHandler("BlogSingle"));
            route.Constraints = new RouteValueDictionary { { "title", @"^\D+" } };
            routeValues = new RouteValueDictionary();
            routeValues.Add("BlogType", 2);
            route.DataTokens = routeValues;
            Routes.Add(route);

            route = new Route("Blog/City/{title}", new BlogSingleRouteHandler("BlogSingle"));
            route.Constraints = new RouteValueDictionary { { "title", @"^\D+" } };
            routeValues = new RouteValueDictionary();
            routeValues.Add("BlogType", 3);
            route.DataTokens = routeValues;
            Routes.Add(route);

            route = new Route("Blog/Arts", new BlogRouteHandler("Blog"));
            routeValues = new RouteValueDictionary();
            routeValues.Add("BlogType", 1);
            route.DataTokens = routeValues;
            Routes.Add(route);

            route = new Route("Blog/City", new BlogRouteHandler("Blog"));
            routeValues = new RouteValueDictionary();
            routeValues.Add("BlogType", 3);
            route.DataTokens = routeValues;
            Routes.Add(route);

            route = new Route("Blog/Business", new BlogRouteHandler("Blog"));
            routeValues = new RouteValueDictionary();
            routeValues.Add("BlogType", 2);
            route.DataTokens = routeValues;
            Routes.Add(route);

            route = new Route("Blog", new BlogRouteHandler("Blog"));
            routeValues = new RouteValueDictionary();
            routeValues.Add("BlogType", 0);
            route.DataTokens = routeValues;
            Routes.Add(route);
        }

        public void BuildUtilityRoutes()
        {
            Route loginRoute = new Route("Login", new DefaultRouteHandler("Login"));
            Routes.Add(loginRoute);

        }
    }
}
