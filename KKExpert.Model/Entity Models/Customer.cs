namespace KKExpert.Model.Entity_Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Customer 
    {
       // private IList<Invoice> invoices;

        public Customer(int id, string name, string vatNumber)
        {
            this.Id = id;
            this.Name = name;
            this.VATNumber = vatNumber;
            this.Invoices = new List<Invoice>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string VATNumber { get; set; }

        public virtual IList<Invoice> Invoices { get; set; }
        public void AddInvoice(Invoice invoice)
        {
            this.Invoices.Add(invoice);
        }
    }
}
