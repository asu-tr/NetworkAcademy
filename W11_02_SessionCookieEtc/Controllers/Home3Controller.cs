using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace W11_02_SessionCookieEtc.Controllers
{
    public class Home3Controller : Controller
    {
        // GET: Home3
        public ActionResult Index()
        {
            HttpContext.Cache.Add("city", "istanbul", null, DateTime.Today.AddDays(10), System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal,null);
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public void MethodToCall(string k, object b, System.Web.Caching.CacheItemRemovedReason a)
        {
            System.IO.File.WriteAllText(Server.MapPath("~/test.txt"), "cache deleted");
        }
    }
}