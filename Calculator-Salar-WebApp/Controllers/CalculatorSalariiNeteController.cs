using Calculator_Salar_WebApp.Models;
using Calculator_Salar_WebApp.Services;
using Microsoft.AspNetCore.Mvc;

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
            if (ModelState.IsValid && _calculNet != null)
            {
                var calculNet = Formulas.FormulaForNetSalaryAndEmployeeTaxesCalculation(_calculNet);

                _context.CalculatorSalariiNete.Add(calculNet);
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