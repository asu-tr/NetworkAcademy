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
            DBContext context = new DBContext();

            List<Computer> list = context.Computers.ToList();

            Computer c = new Computer();
            c.Brand = "MSI";
            c.GPU_ = "RTX3080";

            context.Computers.Add(c);

            context.SaveChanges();

            return View(list);
        }

        [HttpPost]
        public ActionResult Home()
        {
            DBContext context = new DBContext;
            context.Database.ExecuteSqlCommand("EXEC AddSomePC");

            List<Computer> list = context.Computers.ToList();
            return View(list);
        }
    }
}