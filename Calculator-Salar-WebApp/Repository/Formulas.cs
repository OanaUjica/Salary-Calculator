using Calculator_Salar_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator_Salar_WebApp.Repository
{
    public class Formulas
    {

        public static CalculatorSalariuNet formulaForNetSalaryCalculation(CalculatorSalariuNet _salariuBrut)
        {
            var calculNet = new CalculatorSalariuNet()
            {
                SalarBrut = _salariuBrut.SalarBrut,
                Cas = (uint)(0.25 * _salariuBrut.SalarBrut),
                Cass = (uint)(0.10 * _salariuBrut.SalarBrut),
                BazaImpozabila = _salariuBrut.SalarBrut - ((uint)(0.25 * _salariuBrut.SalarBrut)) - ((uint)(0.10 * _salariuBrut.SalarBrut)),
                Impozit = (uint)(0.10 * (_salariuBrut.SalarBrut - ((uint)(0.25 * _salariuBrut.SalarBrut)) - ((uint)(0.10 * _salariuBrut.SalarBrut)))),
                SalarNet = _salariuBrut.SalarBrut - ((uint)(0.25 * _salariuBrut.SalarBrut)) - ((uint)(0.10 * _salariuBrut.SalarBrut)) - ((uint)(0.10 * (_salariuBrut.SalarBrut - ((uint)(0.25 * _salariuBrut.SalarBrut)) - ((uint)(0.10 * _salariuBrut.SalarBrut)))))
            };

            return calculNet;
        }
    }
}
