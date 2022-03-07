using System.Linq;
using System.Web.Mvc;
using W09_10_EFCodeFirst.Models;

namespace W09_10_EFCodeFirst.Controllers
{
    public class PersonController : Controller
    {
        #region NewPerson
        public ActionResult NewPerson()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewPerson(Person p)
        {
            AddressDB db = new AddressDB();
            db.People.Add(p);

            int result = db.SaveChanges();

            if (result > 0)
                ViewBag.Message = "Person saved.";
            else
                ViewBag.Message = "An error occured.";

            return View();
        }
        #endregion

        #region EditPerson

        public ActionResult Edit(int personId)
        {
            AddressDB db = new AddressDB();
            Person p = db.People.Where(x => x.Id == personId).First();

            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(Person newInfo, int personId)
        {
            AddressDB db = new AddressDB();
            Person p = db.People.Where(x => x.Id == personId).First();

            p.Name = newInfo.Name;
            p.Age = newInfo.Age;

            int result = db.SaveChanges();

            if (result > 0)
                ViewBag.Message = "Person saved.";
            else
                ViewBag.Message = "An error occured.";

            return View(p);
        }

        #endregion

        #region DeletePerson

        public ActionResult Delete(int? personId)
        {
            AddressDB db = new AddressDB();
            Person p = db.People.Where(x => x.Id == personId).First();

            return View(p);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePerson(int? personId)
        {
            AddressDB db = new AddressDB();
            Person p = new Person();

            if (personId != null)
            {
                p = db.People.Where(x => x.Id == personId).First();

                foreach (Address a in p.AddressList.ToList())
                {
                    db.Addresses.Remove(a);
                }
                db.People.Remove(p);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }

        #endregion
    }
}