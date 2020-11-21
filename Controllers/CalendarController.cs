using MGRescue_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGRescue_System.Controllers
{
    public class CalendarController : Controller
    {
        ApplicationDbContext context;

        public CalendarController()
        {
            context = new ApplicationDbContext();
        }
        // GET: MasterCalendar
        public ActionResult Index()
        {
            return View(context.Events.ToList());
        }
        public ActionResult Calendar()
        {
            return View();
        }
        public JsonResult GetEvents()
        {
            var events = context.Events.ToList();
            return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        [HttpPost]
        public JsonResult SaveEvent(Event e)
        {
            var status = false;
            if(e.EventID > 0)
            {
                //update the event
                var v = context.Events.Where(a => a.EventID == e.EventID).FirstOrDefault();
                if (v != null)
                {
                    v.Subject = e.Subject;
                    v.Start = e.Start;
                    v.End = e.End;
                    v.Description = e.Description;
                    v.IsFullDay = e.IsFullDay;
                    v.ThemeColor = e.ThemeColor;
                }
            }
            else
            {
                context.Events.Add(e);
            }
            context.SaveChanges();
            status = true;
            return new JsonResult { Data = new { status = status } };
        }
        [HttpPost]
        public JsonResult DeleteEvent(int eventID)
        {
            var status = false;
            var v = context.Events.Where(a => a.EventID == eventID).FirstOrDefault();
            if (v != null)
            {
                context.Events.Remove(v);
                context.SaveChanges();
                status = true;
            }
            return new JsonResult { Data = new { status = status } };
        }
    }
}