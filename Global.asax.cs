using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using XLibrary.Models.DbModels;
using XLibrary.Models.XCodeModels;

namespace XLibrary
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<XDbContext>(null);
            // Auto Mapper Configurations 
            // ex. taken from https://stackoverflow.com/questions/42508231/automapper-5-2-how-to-configure/42508429
            AutoMapper.Mapper.Initialize(cfg => {
                cfg.CreateMap<Users, AuthenticationModel>();
                /* etc */
            });
        }
    }
}
