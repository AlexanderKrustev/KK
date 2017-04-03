namespace KKExpert.Web.Controllers
{
    using System.Web.Mvc;
    using Rotativa;

    public class DownloadController : Controller
    {
        // GET: Download
        public ActionResult DownloadAsPdf()
        {

            return new ViewAsPdf("~/Views/Account/Register.cshtml")
            {
                FileName = "Test.pdf"
            };
        }
    }
}
    
