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
        private List<Trainee> _trainees;   
        public TraineesController()
        {
            _trainees = new List<Trainee>();
            _trainees.Add(new Trainee()
            {
                Id = 1,
                FullName = "Nguyen Van Loc",
                Gender = "Male",
                BDay = DateTime.Now,
                Course = "Application Deverlopment"
            });
            _trainees.Add(new Trainee()
            {
                Id = 2,
                FullName = "Tran Quan Duy",
                Gender = "Male",
                BDay = DateTime.Now,
                Course = "Application Deverlopment"
            });
        }
        // GET: Trainees
        public ActionResult Index()
        {
            return View(_trainees);
        }

        public ActionResult Details(int id)
        {
            var trainee = _trainees.SingleOrDefault(t => t.Id == id);
            if (trainee == null)
                return HttpNotFound();
            return View(trainee);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}