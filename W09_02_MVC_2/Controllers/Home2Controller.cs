using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace W09_02_MVC_2.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Blog2()
        {
            return View();
        }
    }
}