namespace KK.Model.Entities
{
    using System.Collections.Generic;
    using Interfaces;
    public class Customer : ICustomer
    {
        private IList<Sale> sales;

        public Customer()
        {
            this.Sales=new List<Sale>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Sale> Sales
        {
            get { return this.sales; }
            set { this.sales = value; }
        }
        public void AddSales(Sale sale)
        {
            this.Sales.Add(sale);
        }
    }
}
