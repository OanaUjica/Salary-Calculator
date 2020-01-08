using Calculator_Salar_WebApp.Models;
using System;

namespace Calculator_Salar_WebApp.Services
{
    public static class Formulas
    {
        // Formula for net salary and the employee taxes (CAS, CASS, taxable base, tax)
        public static NetSalaryCalculator ForNetSalaryAndEmployeeTaxesCalculationFromGrossSalary(NetSalaryCalculator _grossSalary)
        {
            var calculationNet = new NetSalaryCalculator()
            {
                GrossSalary = _grossSalary.GrossSalary,
                Cas = FormulaForCas(_grossSalary),
                Cass = FormulaForCass(_grossSalary),
                TaxableBase = FormulaForTaxableBase(_grossSalary),
                Tax = FormulaForTax(_grossSalary),
                NetSalary = FormulaForNetSalary(_grossSalary)
            };

            return calculationNet;
        }

        // Formula for CAS
        public static uint FormulaForCas(NetSalaryCalculator _grossSalary)
        {
            var cas = (uint)(0.25 * _grossSalary.GrossSalary);
            return cas;
        }

        // Formula for CASS
        public static uint FormulaForCass(NetSalaryCalculator _grossSalary)
        {
            var cass = (uint)(0.10 * _grossSalary.GrossSalary);
            return cass;
        }

        // Formula for taxable base
        public static uint FormulaForTaxableBase(NetSalaryCalculator _grossSalary)
        {
            var taxableBase = _grossSalary.GrossSalary - ((uint)(0.25 * _grossSalary.GrossSalary)) - ((uint)(0.10 * _grossSalary.GrossSalary));
            return taxableBase;
        }

        // Formula for tax
        public static uint FormulaForTax(NetSalaryCalculator _grossSalary)
        {
            var tax = (uint)(0.10 * (_grossSalary.GrossSalary - ((uint)(0.25 * _grossSalary.GrossSalary)) - ((uint)(0.10 * _grossSalary.GrossSalary))));
            return tax;
        }

        // Formula for net salary
        public static uint FormulaForNetSalary(NetSalaryCalculator _grossSalary)
        {
            var netSalary = _grossSalary.GrossSalary - ((uint)(0.25 * _grossSalary.GrossSalary)) - ((uint)(0.10 * _grossSalary.GrossSalary)) 
                                                   - ((uint)(0.10 * (_grossSalary.GrossSalary - ((uint)(0.25 * _grossSalary.GrossSalary)) 
                                                   - ((uint)(0.10 * _grossSalary.GrossSalary)))));
            return netSalary;
        }
    }
}
