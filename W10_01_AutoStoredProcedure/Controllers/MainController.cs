using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using W10_01_AutoStoredProcedure.Models;

namespace W10_01_AutoStoredProcedure.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Home()
        {
            DBContext db = new DBContext();
            db.Computers.ToList();

            Computer c = new Computer();
            c.Brand = "MSI";
            c.GPU_ = "RTX3060";

            db.Computers.Add(c);

            return View();
        }
    }
}