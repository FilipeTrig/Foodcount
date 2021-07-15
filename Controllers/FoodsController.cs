using Foodcount.Data;
using Foodcount.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodcount.Controllers
{
    public class FoodsController : Controller
    {
        private readonly AppDbContext _db;       

        public FoodsController(AppDbContext db)
        {
            _db = db;
        }

        // GET: FoodsController
        public ActionResult Index()
        {
            IEnumerable<FoodsModel> objList = _db.Foods;          
            return View(objList);
        }

        // GET: FoodsController/Details/5
        public ActionResult Details(string Name)
        {            
            return View();
        }

        // GET: FoodsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FoodsModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Foods.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET: FoodsController/Edit/5
        public ActionResult Edit(string? Name)
        {
            if (Name == null)
            {
                return NotFound();
            }
            var obj = _db.Foods.Find(Name);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST: FoodsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FoodsModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Foods.Update(obj);
                _db.SaveChanges();
                /*if (!String.IsNullOrEmpty(Password))
                {
                    MyStaticValues.UserFB.User.ChangePasswordAsync(Password);
                }*/
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET: FoodsController/Delete/5
        public ActionResult Delete(string? Name)
        {
            if (Name == null)
            {
                return NotFound();
            }
            var obj = _db.Foods.Find(Name);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST: FoodsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(FoodsModel obj)
        {

            if (ModelState.IsValid)
            {
                return NotFound();
            }
            _db.Foods.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
