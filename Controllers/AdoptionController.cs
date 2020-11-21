using MGRescue_System.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MGRescue_System.Controllers
{
    public class AdoptionController : Controller
    {
        ApplicationDbContext context;
        public AdoptionController()
        {
            context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            return View(context.Adoptions.ToList());
        }
        // GET: Adoption
        public ActionResult Cats()
        {
            return View();
        }
        public ActionResult Dogs()
        {
            return View();
        }
        public ActionResult Rabbits()
        {
            return View();
        }
        public ActionResult Smallies()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Upload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Upload(Adoption adoption)
        {
            string fileName = Path.GetFileNameWithoutExtension(adoption.ImageFile.FileName);
            string extension = Path.GetExtension(adoption.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            adoption.ImagePath = "~/AdoptionImgs/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/AdoptionImgs/"), fileName);
            adoption.ImageFile.SaveAs(fileName);
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Adoptions.Add(adoption);
                db.SaveChanges();
            }
            ModelState.Clear();
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,MessageType,To,Message,Name,Email,PhoneNumber")] Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                context.Entry(feedback).State = System.Data.Entity.EntityState.Modified;
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(feedback);
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AdoptionAnimals()
        {

            return View(context.Adoptions.ToList());
        }
    }
}