using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace DylanAppApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",
                @"C:\Users\Dylan\source\repos\CST-356-Weel-9-Lab\CST356 Week 5 Lab\CST356 Week 5 Lab\App_Data");
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
