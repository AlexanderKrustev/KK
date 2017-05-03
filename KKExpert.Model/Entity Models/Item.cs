namespace KKExpert.Model.Entity_Models
{
    using System.Collections.Generic;

    public class Item 
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public virtual IList<Invoice> Invoices { get; set; }
    }
}
