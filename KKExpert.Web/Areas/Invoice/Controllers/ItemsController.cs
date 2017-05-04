namespace KKExpert.Web.Areas.Invoice.Controllers
{
    using System.Web.Mvc;
    using KKEcpert.Service;
    using KKEcpert.Service.Interface;
    using KKExpert.Model.Binding_Models;
    using KKExpert.Model.Entity_Models;
    using KKExpert.Model.View_Models.Invoice;
    using KKExpert.Web.Atrribute;

    [MyAuthorize(Roles = "invoice")]
    public class ItemsController : Controller
    {
        private IItemService itemService;

        public ItemsController(IItemService _itemService)
        {
            this.itemService = _itemService;
        }
        // GET: Invoice/Items
        public ActionResult Index()
        {
            var items = this.itemService.GetAllItems();
            if (items != null)
            {
                return this.View(items);
            }

            return RedirectToAction("Create", "Items");
        }

        // GET: Invoice/Items/Details/5
        public ActionResult Details(int id)
        {

            ItemVm item = this.itemService.GetItemById(id);
            if (item == null)
            {
                return this.HttpNotFound();
            }
            return this.View(item);
        }

        // GET: Invoice/Items/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Invoice/Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemBm item)
        {
            if (this.ModelState.IsValid && item!=null)
            {
                this.itemService.CreateItem(item);
                return RedirectToAction("Index");
            }

            return View(item);
        }

    }
}
