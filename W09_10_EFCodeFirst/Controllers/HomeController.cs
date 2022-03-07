using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using W09_10_EFCodeFirst.Models;

namespace W09_10_EFCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AddressDB db = new AddressDB();

            List<Person> people = db.People.ToList();
            return View(people);
        }
    }
}