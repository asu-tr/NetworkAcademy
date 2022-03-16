using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace W11_02_SessionCookieEtc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string text)
        {
            Session["value"] = text;
            return View();
        }

        public ActionResult Index2()
        {
            if (Session["Value"] != null)
                ViewBag.Value = Session["value"].ToString();
            else
                ViewBag.Value = "SESSION NOT FOUND";
            
            return View();
        }

        public ActionResult Index3()
        {
            //Session.Clear();

            if (Session["Value"] != null)
                Session.Remove("Value");
            else
                ViewBag.Value = "SESSION WAS NOT AVAILABLE";

            return View();
        }
    }
}