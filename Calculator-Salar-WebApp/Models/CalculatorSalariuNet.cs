using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator_Salar_WebApp.Models
{
    public class CalculatorSalariuNet
    {
        public int Id { get; set; }

        [Display(Name = "Salar Brut")]
        public uint SalarBrut { get; set; }

        [Display(Name = "CAS")]
        public uint Cas { get; set; }

        [Display(Name = "CASS")]
        public uint Cass { get; set; }

        [Display(Name = "Venit Impozabil")]
        public uint BazaImpozabila { get; set; }

        [Display(Name = "Impozit")]
        public uint Impozit { get; set; }

        [Display(Name = "Salar Net")]
        public uint SalarNet { get; set; }

    }
}
