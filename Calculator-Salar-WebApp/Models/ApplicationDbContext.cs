using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator_Salar_WebApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CalculatorSalariuBrut> CalculatorSalariuBrut { get; set; }
        public DbSet<CalculatorSalariuNet> CalculatorSalariuNet { get; set; }


    }
}
