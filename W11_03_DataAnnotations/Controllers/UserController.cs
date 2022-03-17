using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using W11_03_DataAnnotations.Models;

namespace W11_03_DataAnnotations.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (user.Username == "Cindy")
            {
                //ModelState.AddModelError("Username", "Username exists.");
                ModelState.AddModelError("", "Username exists.");
            }

            return View(user);
        }
    }
}