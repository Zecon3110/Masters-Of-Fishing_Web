using Masters_Of_Fishing_Web.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Masters_Of_Fishing_Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
			//var db = new Database(@"Data Source = D:\Programmer\Visual Studio\Projects\Masters-Of-Fishing_Web\Masters-Of-Fishing_Web\bin\MastersOfFishing.db; Version = 3;");
			//db.Get();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
