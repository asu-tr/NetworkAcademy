using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using W12_03_Filter.Models;

namespace W12_03_Filter.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult SignIn(User model)
        {
            return View();
        }
    }
}