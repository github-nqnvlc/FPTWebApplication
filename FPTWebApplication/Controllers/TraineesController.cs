using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FPTWebApplication.Models;

namespace FPTWebApplication.Controllers
{
    public class TraineesController : Controller
    {
        private ApplicationDbContext _context;
        private List<Trainee> _trainees;
        public TraineesController()
        {

            _context = new ApplicationDbContext();
        }
        // GET: Trainees
        public ActionResult Index()
        {
            var trainees = _context.Trainees.ToList();
            return View(trainees);
        }

        public ActionResult Details(int id)
        {
            if (id == null) return HttpNotFound();
            var trainee = _context.Trainees.SingleOrDefault(t => t.Id == id);
            if (trainee == null) return HttpNotFound();
            return View(trainee);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null) return HttpNotFound();
            var trainee = _context.Trainees.SingleOrDefault(t => t.Id == id);
            if (trainee == null) return HttpNotFound();
            _context.Trainees.Remove(trainee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}