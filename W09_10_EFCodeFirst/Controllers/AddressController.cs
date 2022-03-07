using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using W09_10_EFCodeFirst.Models;

namespace W09_10_EFCodeFirst.Controllers
{
    public class AddressController : Controller
    {
        #region NewAddress
        public ActionResult NewAddress()
        {
            AddressDB db = new AddressDB();

            List<SelectListItem> peopleList =
                (from p in db.People.ToList()
                 select new SelectListItem()
                 {
                     Text = p.Name,
                     Value = p.Id.ToString()
                 }).ToList();

            ViewBag.people = peopleList;

            TempData["people"] = peopleList;

            return View();
        }

        [HttpPost]
        public ActionResult NewAddress(Address a)
        {
            AddressDB db = new AddressDB();

            Person person = db.People.Where(p => p.Id == a.Person.Id).First();

            a.Person = person;

            db.Addresses.Add(a);
            int result = db.SaveChanges();

            if (result > 0)
            {
                ViewBag.Message = "Address saved.";
            }
            else
                ViewBag.Message = "An error occured.";

            ViewBag.people = TempData["people"];

            return View();
        }
        #endregion

        #region EditAddress

        public ActionResult Edit(int addressId)
        {
            AddressDB db = new AddressDB();
            Address a = db.Addresses.Where(x => x.Id == addressId).First();

            return View(a);
        }

        [HttpPost]
        public ActionResult Edit(Address newInfo, int addressId)
        {
            AddressDB db = new AddressDB();

            Address a = db.Addresses.Where(x => x.Id == addressId).First();
            a.Description = newInfo.Description;

            int result = db.SaveChanges();

            if (result > 0)
                ViewBag.Message = "Address saved.";
            else
                ViewBag.Message = "An error occured.";

            return View(a);
        }

        #endregion

        #region DeleteAddress

        public ActionResult Delete(int? addressId)
        {
            AddressDB db = new AddressDB();
            Address a = db.Addresses.Where(x => x.Id == addressId).First();

            return View(a);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteAddress(int? addressId)
        {
            AddressDB db = new AddressDB();
            Address a = new Address();

            if (addressId != null)
            {
                a = db.Addresses.Where(x => x.Id == addressId).First();

                db.Addresses.Remove(a);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }

        #endregion
    }
}