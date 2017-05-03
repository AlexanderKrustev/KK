namespace KKExpert.Model.Entity_Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Customer 
    {
     
        public Customer()
        {
            this.Invoices = new List<Invoice>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string VATNumber { get; set; }
        public virtual IList<Invoice> Invoices { get; set; }
        
    }
}
