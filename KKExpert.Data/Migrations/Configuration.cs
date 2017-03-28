namespace KKExpert.Data.Migrations
{

    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<KKExpertContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(KKExpertContext context)
        {
            if (!context.Roles.Any(x => x.Name == "invoice"))
            {
                var store = new RoleStore<IdentityRole> (context);
                var manager = new RoleManager<IdentityRole>(store);
                var role=new IdentityRole("invoice");
                manager.Create(role);
            }
            if (!context.Roles.Any(x => x.Name == "admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("admin");
                manager.Create(role);
            }
            if (!context.Roles.Any(x => x.Name == "user"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("user");
                manager.Create(role);
            }
        }

       

    }
}
