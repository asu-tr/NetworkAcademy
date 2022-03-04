using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using W09_10_EFCodeFirst.Models;

namespace W09_10_EFCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            AddressDB db = new AddressDB();

            //AdrsPrsn adrsPrsn = new AdrsPrsn();
            //adrsPrsn.Persons = db.Persons.ToList();
            //adrsPrsn.Addresses = db.Addresses.ToList();
            //return View(adrsPrsn);

            List<Person> people = db.Persons.ToList();
            return View(people);
        }
    }
}