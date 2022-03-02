using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using W09_07_ModelBinding.Models;

namespace W09_07_ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Person person = new Person();
            person.Name = "Max";
            person.Age = 20;

            Address address = new Address();
            address.City = "Istanbul";
            address.Country = "Turkey";

            ViewModel vm = new ViewModel();
            vm.Address = address;
            vm.Person = person;

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(ViewModel vm)
        {

            return View();
        }
    }
}