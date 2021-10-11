using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lend_CRUD.Controllers
{
    public class appointmentController : Controller
    {
        public IActionResult Index()
        {
            string todaysDate = DateTime.Now.ToShortDateString();
            return View();
        }
    }
}