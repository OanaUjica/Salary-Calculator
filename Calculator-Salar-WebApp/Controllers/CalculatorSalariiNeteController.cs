using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator_Salar_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Calculator_Salar_WebApp.Repository;

namespace Calculator_Salar_WebApp.Controllers
{
    public class CalculatorSalariiNeteController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CalculatorSalariiNeteController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([Bind("SalarBrut")] CalculatorSalariuNet _calculNet)
        {
            if (ModelState.IsValid)
            {
                CalculatorSalariuNet calculNet = Formulas.formulaForNetSalaryCalculation(_calculNet);

                _context.CalculatorSalariuNet.Add(calculNet);
                _context.SaveChanges();
                return RedirectToAction(nameof(CalculNet), "CalculatorSalariiNete", calculNet) ;
            }

            return View(_calculNet);
        }


        public IActionResult CalculNet(CalculatorSalariuNet _calculNet)
        {
            return View(_calculNet);
        }

    }
}