using System.Web.Mvc;

namespace W09_05_FromControllerToView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["text1"] = "THE TEXT";
            ViewData["check"] = true;

            ViewBag.text1 = "THE VIEWBAG TEXT";
            ViewBag.text2 = "TEXT 2";

            TempData["Text3"] = "THE TEXT 3";
            TempData["Check2"] = false;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.text1 = "THE VIEWBAG TEXT";
            TempData["text2"] = "TEXT 2";


            ViewBag.liste = new SelectListItem[]
            {
                new SelectListItem(){Text="one", Value="1"},
                new SelectListItem(){Text= "two", Value="2"},
                new SelectListItem(){Text = "three", Value ="3"}
            };

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.t2t2 = TempData["text2"];

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.t3 = TempData["text2"];

            return View();
        }
    }
}