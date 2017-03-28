namespace KKExpert.Model.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IInvoice
    {
        int Id { get; set; }

        string InvoiceNumber { get; set; }

        DateTime DateOfUssue { get; set; }

        string PaymentMethod { get; set; }

        decimal Price { get; set; }

        IEnumerable<IItem> Items { get; set; }

        void AddItem(IItem item);


    }
}
