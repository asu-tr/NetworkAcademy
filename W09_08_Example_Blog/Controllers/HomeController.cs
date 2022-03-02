using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace W09_08_Example_Blog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            return View();
        }
    }
}