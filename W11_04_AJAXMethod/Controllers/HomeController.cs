using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace W11_04_AJAXMethod.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public List<string> list = new List<string>()
            {
                "carrot",
                "pineapple",
                "banana",
                "orange",
                "dragon fruit",
                "blueberry",
                "mango"
            };

        public PartialViewResult GetData()
        {
            System.Threading.Thread.Sleep(2500);
            return PartialView("_PartialData", list);
        }

        public PartialViewResult DeleteData(int id)
        {
            list.RemoveAt(id);
            return PartialView("_PartialData", list);
        }
    }
}