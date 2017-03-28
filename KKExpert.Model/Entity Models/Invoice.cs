namespace KKExpert.Model.Entity_Models
{
    using System;
    using System.Collections.Generic;

    public class Invoice 
    {
        private IList<Item> items;

        public Invoice(int id, string invoiceNumber, DateTime dateOfUssue, string paymentMethod, decimal price)
        {
            this.Id = id;
            this.InvoiceNumber = invoiceNumber;
            this.DateOfUssue = dateOfUssue;
            this.PaymentMethod = paymentMethod;
            this.Price = price;
            this.Items = new List<Item>();
        }
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime DateOfUssue { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Price { get; set; }

        public virtual IList<Item> Items
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
