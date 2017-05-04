namespace KKExpert.Data
{
    using System.Data.Entity;
    using Interfaces;
    using Model.Entity_Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class KKExpertContext : IdentityDbContext<ApplicationUser>, IKKExpertContext
    {
       public KKExpertContext()
            : base("KKExpertContext", throwIfV1Schema: false)
        {
        }

          public static KKExpertContext Create()
            {
                return new KKExpertContext();
            }
        



        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Item> Items { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<User> Users { get; set; }

      
     // protected override void OnModelCreating(DbModelBuilder modelBuilder)
     // {
     // 
     //     modelBuilder.Entity<Invoice>()
     //                 .HasMany<Item>(s => s.Items)
     //                 .WithMany(c => c.Invoices)
     //                 .Map(cs =>
     //                 {
     //                     cs.MapLeftKey("InvoiceRefId");
     //                     cs.MapRightKey("ItemRefId");
     //                     cs.ToTable("InvoiceItems");
     //                 });
     // 
     //     
     // }

    }

   
}