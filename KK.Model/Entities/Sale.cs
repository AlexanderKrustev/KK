namespace KK.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class Sale
    {
        private decimal price;
        private ICollection<IItem> items;

        public Sale()
        {
            this.items=new List<IItem>();
        }
        public ICustomer CustomerName { get; set; }

        public IUser UserName { get; set; }

        public ICollection<IItem> Items { get; set; }

        public Decimal Price { get; set; }

        public void AddArticleToSale(IItem item)
        {
            this.Items.Add(item);
            this.price += item.Price;
        }
    }
}
