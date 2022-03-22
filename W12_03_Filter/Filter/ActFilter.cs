using System;
using System.Web.Mvc;
using W12_03_Filter.Models;

namespace W12_03_Filter.Filter
{
    public class ActFilter : FilterAttribute, IActionFilter
    {
        MyContext db = new MyContext();

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            db.Logs.Add(new MyLog()
            {
                Username = "sth",
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                DateTime = DateTime.Now,
                Info = "Action Ended"
            });

            db.SaveChanges();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            db.Logs.Add(new MyLog()
            {
                Username = "sth",
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                DateTime = DateTime.Now,
                Info = "Action Running"
            });

            db.SaveChanges();
        }
    }
}