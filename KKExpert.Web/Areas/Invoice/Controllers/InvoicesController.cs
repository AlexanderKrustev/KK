namespace KKExpert.Web.Areas.Invoice.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using AutoMapper;
    using KKEcpert.Service.Invoice;
    using KKEcpert.Service.Item;
    using KKExpert.Model.Binding_Models;
    using KKExpert.Model.Entity_Models;
    using KKExpert.Model.View_Models.Invoice;
    using KKExpert.Web.Atrribute;


    [MyAuthorize(Roles = "invoice")]
    public class InvoicesController : Controller
    {
        private InvoiceService invoiceService= new InvoiceService();
        private ItemService itemService = new ItemService();
        private int count = 0;

        // GET: Invoice/Invoices
        public ActionResult Index()
        {
            var invoices = this.invoiceService.GetAllInvoices();
            IEnumerable<InvoiceVm> invoicesVm = Mapper.Map<IEnumerable<Invoice>, IEnumerable<InvoiceVm>>(invoices);
            if (invoicesVm != null)
            {
                return View(invoicesVm);
            }

            return RedirectToAction("Create", "Invoices");
        }

        // GET: Invoice/Invoices/Details/5
        public ActionResult Details(int id)
        {
            Invoice invoice = this.invoiceService.GetInvoiceById(id);

            if (invoice == null)
            {
                return this.HttpNotFound();
            }

            return this.View(invoice);
        }

        // GET: Invoice/Invoices/Create
        public ActionResult Create()
        {
            ViewBag.Data= this.itemService.GetAllItems();
            return this.View();
        }

        // POST: Invoice/Invoices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InvoiceBm invoice, string[] ItemsSelectList)
        {

            if (this.ModelState.IsValid)
            {
                this.invoiceService.CreateInvoice(invoice, ItemsSelectList);
                return RedirectToAction("Index");
            }

            return View();
        }


       }
}
