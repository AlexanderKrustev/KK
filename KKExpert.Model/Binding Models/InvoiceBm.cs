namespace KKExpert.Model.Binding_Models
{
    using System;

    public class InvoiceBm
    {
        public string InvoiceNumber { get; set; }
        public DateTime DateOfUssue { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Price { get; set; }

    }
}
