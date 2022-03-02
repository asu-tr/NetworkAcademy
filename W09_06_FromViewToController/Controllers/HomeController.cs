using System.Web.Mvc;

namespace W09_06_FromViewToController.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string txt1, bool check1)
        {
            var text = Request.Form["txt1"];
            var ctrl = Request.Form.GetValues("check1")[0];

            return View();
        }
    }
}