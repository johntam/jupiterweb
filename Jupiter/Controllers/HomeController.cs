using System.Web.Mvc;

namespace Jupiter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Jupiter is available on all your devices";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Jupiter app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My contacts page.";

            return View();
        }
    }
}
