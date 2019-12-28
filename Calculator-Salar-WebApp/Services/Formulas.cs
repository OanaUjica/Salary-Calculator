using Calculator_Salar_WebApp.Models;
using System;

namespace Calculator_Salar_WebApp.Services
{
    public class Formulas
    {
        private Formulas()
        {

        }

        // Formula for net salary and the employee taxes (CAS, CASS, taxable base, tax)
        public static CalculatorSalariuNet ForNetSalaryAndEmployeeTaxesCalculationFromGrossSalary(CalculatorSalariuNet _salariuBrut)
        {
            var calculNet = new CalculatorSalariuNet()
            {
                SalarBrut = _salariuBrut.SalarBrut,
                Cas = FormulaForCas(_salariuBrut),
                Cass = FormulaForCass(_salariuBrut),
                BazaImpozabila = FormulaForTaxableBase(_salariuBrut),
                Impozit = FormulaForTax(_salariuBrut),
                SalarNet = FormulaForNetSalary(_salariuBrut)
            };

            return calculNet;
        }

        // Formula for CAS
        public static uint FormulaForCas(CalculatorSalariuNet _salariuBrut)
        {
            var cas = (uint)(0.25 * _salariuBrut.SalarBrut);
            return cas;
        }

        // Formula for CASS
        public static uint FormulaForCass(CalculatorSalariuNet _salariuBrut)
        {
            var cass = (uint)(0.10 * _salariuBrut.SalarBrut);
            return cass;
        }

        // Formula for taxable base
        public static uint FormulaForTaxableBase(CalculatorSalariuNet _salariuBrut)
        {
            var taxableBase = _salariuBrut.SalarBrut - ((uint)(0.25 * _salariuBrut.SalarBrut)) - ((uint)(0.10 * _salariuBrut.SalarBrut));
            return taxableBase;
        }

        // Formula for tax
        public static uint FormulaForTax(CalculatorSalariuNet _salariuBrut)
        {
            var tax = (uint)(0.10 * (_salariuBrut.SalarBrut - ((uint)(0.25 * _salariuBrut.SalarBrut)) - ((uint)(0.10 * _salariuBrut.SalarBrut))));
            return tax;
        }

        // Formula for net salary
        public static uint FormulaForNetSalary(CalculatorSalariuNet _salariuBrut)
        {
            var netSalary = _salariuBrut.SalarBrut - ((uint)(0.25 * _salariuBrut.SalarBrut)) - ((uint)(0.10 * _salariuBrut.SalarBrut)) - ((uint)(0.10 * (_salariuBrut.SalarBrut - ((uint)(0.25 * _salariuBrut.SalarBrut)) - ((uint)(0.10 * _salariuBrut.SalarBrut)))));
            return netSalary;
        }
    }
}
