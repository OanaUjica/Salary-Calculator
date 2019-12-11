using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator_Salar_WebApp.Models;
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
        public IActionResult CalculNet([Bind("SalarBrut")] CalculatorSalariuNet _calculNet)
        {
            if (ModelState.IsValid)
            {
                var calculNet = new CalculatorSalariuNet()
                {
                    SalarBrut = _calculNet.SalarBrut,
                    Cas = (uint)(0.25 * _calculNet.SalarBrut),
                    Cass = (uint)(0.10 * _calculNet.SalarBrut),
                    BazaImpozabila = _calculNet.SalarBrut - ((uint)(0.25 * _calculNet.SalarBrut)) - ((uint)(0.10 * _calculNet.SalarBrut)),
                    Impozit = (uint)(0.10 * (_calculNet.SalarBrut - ((uint)(0.25 * _calculNet.SalarBrut)) - ((uint)(0.10 * _calculNet.SalarBrut)))),
                    SalarNet = _calculNet.SalarBrut - ((uint)(0.25 * _calculNet.SalarBrut)) - ((uint)(0.10 * _calculNet.SalarBrut)) - ((uint)(0.10 * (_calculNet.SalarBrut - ((uint)(0.25 * _calculNet.SalarBrut)) - ((uint)(0.10 * _calculNet.SalarBrut)))))

                };


                _context.CalculatorSalariuNet.Add(calculNet);
                _context.SaveChanges();
                return View(calculNet);
            }

            return RedirectToAction(nameof(Index),"CalculatorSalariiNete");
        }

    }
}