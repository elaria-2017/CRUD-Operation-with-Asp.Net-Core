using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lend_CRUD.Data;
using Lend_CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lend_CRUD.Controllers
{
    public class itemController : Controller
    {
        private readonly ApplicationDbContext _db;
        public itemController(ApplicationDbContext db) {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<item> objList = _db.items;
            return View(objList);
        }
        

        public IActionResult Create()
        {
             
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(item obj) {
             _db.items.Add(obj);
             _db.SaveChanges();
          return RedirectToAction("Index");
        }

    }
}