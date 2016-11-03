using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using noexcuses.Models;
using noexcuses.Models.WeeklystandingsViewModels;
using noexcuses.Services;
using noexcuses.Data;



namespace noexcuses.Controllers
{
    public class WeeklystandingsController : Controller
    {
        private ApplicationDbContext db;
       public WeeklystandingsController(ApplicationDbContext wkM){
           db = wkM;
       }

        public ActionResult Index()
        {
            var vmee = new WeeklyStatndingsModel();
            return View(db.WklyStands.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            var vm = new WeeklyStatndingsModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Create(WeeklyStatndingsModel wkmodel)
        {
            if(ModelState.IsValid){
                db.WklyStands.Add(wkmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}