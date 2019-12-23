using Microsoft.EntityFrameworkCore;


namespace Calculator_Salar_WebApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CalculatorSalariuBrut> CalculatorSalariiBrute { get; set; }
        public DbSet<CalculatorSalariuNet> CalculatorSalariiNete { get; set; }


    }
}
