using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_Salar_WebApp.Controllers
{
    public class CalculatorSalariiBruteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}