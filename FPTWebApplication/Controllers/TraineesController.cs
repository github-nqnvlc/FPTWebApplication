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
        private Trainee _trainee;
        public TraineesController()
        {
            _trainee = new Trainee()
            {
                Id = 1,
                FullName = "Nguyen Van Loc",
                BDay = DateTime.Now,
                Course = "Application Deverlopment"
            };
        }
        // GET: Trainees
        public ActionResult Index()
        {
            return View(_trainee);
        }
    }
}