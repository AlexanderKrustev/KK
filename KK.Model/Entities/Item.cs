namespace KK.Model.Entities
{
    using System.Collections.Generic;
    using Interfaces;
    public class Item : IItem
    {
        private IDictionary<string, string> details;
        private IList<User> salesByUsers;

        public Item()
        {
            this.details=new Dictionary<string, string>();
            this.salesByUsers=new List<User>();
        }
        public int Id { get; }
        public decimal Price { get; set; }
        public string Name { get; set; }

        public IDictionary<string, string> Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        public IList<User> SaleByUsers
        {
            get { return this.salesByUsers; }
            set { this.salesByUsers = value; }
        }
    }
}
