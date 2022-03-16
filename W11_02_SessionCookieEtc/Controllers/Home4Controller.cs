using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace W11_02_SessionCookieEtc.Controllers
{
    public class Home4Controller : Controller
    {
        // GET: Home4
        public ActionResult Index()
        {
            HttpCookie cookie = new HttpCookie("Username", "asu");
            HttpContext.Response.Cookies.Add(cookie);

            return View();
        }

        public ActionResult Index2()
        {
            if (HttpContext.Request.Cookies["Username"] != null)
                ViewBag.CookieUsername = HttpContext.Request.Cookies["Username"].Value;
            else
                ViewBag.CookieUsername = "Cookie not found.";

            return View();
        }

        public ActionResult Index3()
        {
            if (HttpContext.Request.Cookies["Username"] != null)
            {
                HttpCookie myCookie = new HttpCookie("Username");
                myCookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(myCookie);
            }

            return View();
        }
    }
}