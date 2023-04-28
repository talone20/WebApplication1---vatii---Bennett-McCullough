using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class whatController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult CalcGrades()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalcGrades(GradesModel model)
        {
            return View();
        }
    }
}
