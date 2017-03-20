namespace KK.Model.Interfaces
{
    using System.Collections.Generic;
    using Entities;

    public interface IItem
    {
        int Id { get;}
        decimal Price { get; set; }
        string Name { get; set; }

        IDictionary<string, string>  Details { get; set; }

        IList<User> SaleByUsers { get; set; }
    }
}
