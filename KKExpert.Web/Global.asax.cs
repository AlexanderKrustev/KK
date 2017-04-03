using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace KKExpert.Web
{
    using AutoMapper;
    using KKExpert.Model.Binding_Models;
    using KKExpert.Model.Entity_Models;
    using KKExpert.Model.View_Models.Account;
    using KKExpert.Model.View_Models.Manage;
    using KKExpert.Web.Mapper;
    using Microsoft.AspNet.Identity;

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
                x.AddProfile<UserBmToUser>();
                x.AddProfile<UserVmToUser>();
                x.AddProfile<UserToUserVm>();
            });



        }
    }
}
