using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGRescue_System.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StaffCalendar()
        {
            return View();
        }
        public ActionResult StaffRota()
        {
            return View();
        }
        public ActionResult StaffContacts()
        {
            return View();
        }
    }
}