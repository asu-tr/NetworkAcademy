using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace W09_10_EFCodeFirst.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult NewPerson()
        {
            return View();
        }
    }
}