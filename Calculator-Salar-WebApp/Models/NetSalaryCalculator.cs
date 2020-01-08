using System.ComponentModel.DataAnnotations;


namespace Calculator_Salar_WebApp.Models
{
    public class NetSalaryCalculator
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Introducerea salariului brut e obligatorie!")]
        [Range(1, int.MaxValue, ErrorMessage = "Salariul brut nu poate avea valoarea 0 sau mai mica decat 0! Te rog reincearca.")]
        [Display(Name = "Salar Brut")]
        public uint GrossSalary { get; set; }

        [Display(Name = "CAS")]
        public uint Cas { get; set; }

        [Display(Name = "CASS")]
        public uint Cass { get; set; }

        [Display(Name = "Venit Impozabil")]
        public uint TaxableBase { get; set; }

        [Display(Name = "Impozit")]
        public uint Tax { get; set; }

        [Display(Name = "Salar Net")]
        public uint NetSalary { get; set; }

    }
}
