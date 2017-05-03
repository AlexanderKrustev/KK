namespace KKEcpert.Service.Invoice
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using KKExpert.Model.Binding_Models;
    using KKExpert.Model.Entity_Models;

    public class InvoiceService : Service
    {

        public IEnumerable<Invoice> GetAllInvoices()
        {
            return this.Context.Invoices.AsEnumerable();

        }

        public Invoice GetInvoiceById(int id)
        {
            return this.Context.Invoices.Find(id);
        }

        public void CreateInvoice(InvoiceBm invoiceBm, string[] items)
        {
            Invoice entityInvoice = Mapper.Map<InvoiceBm, Invoice>(invoiceBm);
            foreach (var item in items)
            {
                Item entityItem = this.Context.Items.Find(int.Parse(item));
                entityInvoice.AddItem(entityItem);
            }
            this.Context.Invoices.Add(entityInvoice);
            this.Context.SaveChanges();
        }
    }
}
