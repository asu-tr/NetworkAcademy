using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace W12_01_JQuery_Ajax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public static List<string> list = new List<string>
        {
            "TV",
            "PC",
            "Mobile Phone"
        };

        public PartialViewResult GetData(string data = "")
        {
            if (!string.IsNullOrEmpty(data))
            {
                list.Add(data);
            }
            System.Threading.Thread.Sleep(1500);
            return PartialView("_PartialData", list);
        }

        public ActionResult Secondary()
        {
            return View();
        }


        public ActionResult ImBoredCantWeDoSomethingElse()
        {
            return View();
        }

        public JsonResult GetData2(string data = "")
        {
            if (!string.IsNullOrEmpty(data))
            {
                list.Add(data);
            }
            System.Threading.Thread.Sleep(1500);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}