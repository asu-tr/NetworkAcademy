using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace W11_02_SessionCookieEtc.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            HttpContext.Application["count"] = 1;

            return View();
        }

        public ActionResult Index2()
        {
            if (HttpContext.Application["count"] != null)
            {
                ViewBag.Count = HttpContext.Application["count"].ToString();
            }
            
            return View();
        }

        public ActionResult Index3()
        {
            if (HttpContext.Application["count"] != null)
            {
                int count = (int)HttpContext.Application["count"];
                count++;

                HttpContext.Application["count"] = count;

                return RedirectToAction("Index2");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Index4()
        {
            HttpContext.Application.Remove("count");
            //HttpContext.Application.Clear();
            //HttpContext.Application.RemoveAll();

            return RedirectToAction("Index2");
        }
    }
}