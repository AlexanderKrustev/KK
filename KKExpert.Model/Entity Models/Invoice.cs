namespace KKExpert.Model.Entity_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class Invoice 
    {
        private IList<Item> items;

        public Invoice()
        {

            this.Items = new List<Item>();
        }
        public Invoice(IEnumerable<Item> inputItems)
        {

            this.Items = inputItems.ToList();
        }

        [Key]
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime DateOfUssue { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Price { get; set; }

        public  IList<Item> Items
        {
            get { return this.items; }
            set { this.items = value; }
        }
        public void AddItem(Item item)
        {
            this.Price += item.Price;
            this.items.Add(item);
        }
    }
}
