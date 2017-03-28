using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KKExpert.Web.Startup))]
namespace KKExpert.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
