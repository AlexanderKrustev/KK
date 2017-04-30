﻿namespace KKExpert.Web
{
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using KKExpert.Model.View_Models.Account;
    using Model.Entity_Models;
    using Model.View_Models.Manage;

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            ConfigureMapper();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            

        }

        private void ConfigureMapper()
        {
            AutoMapper.Mapper.Initialize(x =>
            {
                x.CreateMap<UserBm, User>();
                x.CreateMap<UserVm, User>(); ;
                x.CreateMap<User, UserVm>(); ;
            });



        }
    }
}
