using System.Web.Mvc;

namespace W09_04_PartialView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            return View();
        }
    }
}