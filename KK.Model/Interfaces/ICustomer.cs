namespace KK.Model.Interfaces
{
    using System.Collections.Generic;
    using KK.Model.Entities;

    public interface ICustomer
    {
        int Id { get; set; }

        string Name { get; set; }

        IList<Sale> Sales { get; set; }

        void AddSales(Sale sale);

    }
}
