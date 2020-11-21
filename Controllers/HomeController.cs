using MGRescue_System.Models;
using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace MGRescue_System.Controllers
{
    public class HomeController : Controller
    {
        private SendGridEmailService _sendGridEmailService;
        //AppLicationDbContext context;
        public HomeController()
        {
            _sendGridEmailService = new SendGridEmailService();
            //context = new AppLicationDbContext();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        //[Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        //[Authorize]
        public ActionResult Trustees()
        {
            ViewBag.Message = "Our Trustees";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult ContactUs()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult ContactUs(ContactViewModel contract)
        {
            if (!ModelState.IsValid)
            {
                return View(contract);
            }

            try
            {
                var response = _sendGridEmailService.SendContact(contract);
                ViewBag.Success = true;
                return View();
            }
            catch (Exception)
            {
                ViewBag.Success = false;
                return View();
            }
        }
       

        [HttpGet]
        public ActionResult TestPage()
        {
            ViewBag.Message = "Test Page";
            return View();
        }
        [HttpGet]
        public ActionResult Calendar()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
                return View(context.Events.ToList());
        }
        public JsonResult GetEvents()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var events = context.Events.ToList();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
               
        }
        [HttpPost]
        public JsonResult SaveEvent(Event e)
        {
            var status = false;
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                if (e.EventID > 0)
                {
                    //Update the event
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

                //if (ModelState.IsValid)
                //{
                //    context.Events.Add(new Event {
                //        Subject = e.Subject, 
                //        Start= e.Start, 
                //        End=e.End, 
                //        Description = e.Description, 
                //        IsFullDay = e.IsFullDay, 
                //        ThemeColor = e.ThemeColor 
                //    }) ;
                //}


                context.SaveChanges();
                status = true;

            }
            return new JsonResult { Data = new { status = status } };
        }
        [HttpPost]
        public JsonResult DeleteEvent(int eventID)
        {
            var status = false;
            using (ApplicationDbContext dc = new ApplicationDbContext())
            {
                var v = dc.Events.Where(a => a.EventID == eventID).FirstOrDefault();
                if (v != null)
                {
                    dc.Events.Remove(v);
                    dc.SaveChanges();
                    status = true;
                }
            }
            return new JsonResult { Data = new { status = status } };
        }
       
    }
}
