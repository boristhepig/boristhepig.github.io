using MGRescue_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGRescue_System.Controllers
{
    public class EmailController : Controller
    {
        private SendGridEmailService _sendGridEmailService;
        public EmailController()
        {
            _sendGridEmailService = new SendGridEmailService();
        }

        //public ActionResult Send()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Send(EmailContract emailContract)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(emailContract);
        //    }
            
        //    try
        //    {
        //        var response= _sendGridEmailService.Send(emailContract);
        //        ViewBag.Success = true;
        //        return View();
        //    }
        //    catch (Exception)
        //    {
        //        ViewBag.Success = false;
        //        return View();
        //    }
        //}

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel contract)
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
    }
}
