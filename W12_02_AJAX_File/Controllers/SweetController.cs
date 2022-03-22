using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace W12_02_AJAX_File.Controllers
{
    public class SweetController : Controller
    {
        // GET: Sweet
        public ActionResult Animals()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SendChocolate(HttpPostedFileBase file)
        {
            if (file != null)
            {
                if (!Directory.Exists(Server.MapPath("~/src/")))
                {
                    Directory.CreateDirectory(Server.MapPath("~/src/"));
                }

                file.SaveAs(Server.MapPath("~/src/") + "_upload_" + System.DateTime.Now.ToString() + "_" + file.FileName);

                return Json(new { error = false, message = "File uploaded." });
            }

            else
                return Json(new { error = true, message = "File COULD NOT be uploaded." });
        }
    }
}