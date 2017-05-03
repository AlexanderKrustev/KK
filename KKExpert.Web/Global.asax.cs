namespace KKExpert.Web
{
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using KKExpert.Model.Binding_Models;
    using KKExpert.Model.View_Models.Account;
    using KKExpert.Model.View_Models.Invoice;
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
                x.CreateMap<UserVm, User>(); 
                x.CreateMap<User, UserVm>(); 
                x.CreateMap<ItemBm, Item>();
                x.CreateMap<Item, ItemBm>();
                x.CreateMap<InvoiceBm, Invoice>();
                x.CreateMap<Invoice, InvoiceVm>();

            });



        }
    }

  
}
