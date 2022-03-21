using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using W11_04_AJAXMethod.Models;

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

        public ActionResult Index2()
        {
            //  ViewBag.List2 = listt;
            return View(new Model1());
        }

        [HttpPost]
        public PartialViewResult Index2(Model1 m)
        {
            List<Model1> listt = null;

            if (Session["liste"] != null)
                listt = (List<Model1>)Session["liste"];
            else
                listt = new List<Model1>();

            ViewBag.List2 = list;

            m.Id = Guid.NewGuid();
            listt.Add(m);

            Session["liste"] = listt;

            System.Threading.Thread.Sleep(3000);

            return PartialView("_PartialModel", m);
        }
    }
}