using Foodcount.Data;
using Foodcount.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodcount.Controllers
{
    public class DishController : Controller
    {
        private readonly AppDbContext _db;

        public DishController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DishModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Dishes.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }



    }
}
