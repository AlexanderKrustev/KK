namespace KKExpert.Model.Interfaces
{
    using System.Collections.Generic;

    public interface ICustomer
    {
        int Id { get; set; }

        string Name { get; set; }

        string VATNumber { get; set; }

        IList<IInvoice> Invoices { get; set; }

        void AddInvoice(IInvoice invoice);
    }
}
