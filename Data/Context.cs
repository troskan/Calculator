using Calculator.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Data
{
    public class Context : DbContext
    {
        public Context()
        {
            
        }
        public Context(DbContextOptions<Context> options)
                   : base(options)
        {
        }

        public DbSet<Calculation> Calculations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calculation>().HasData(
                new Calculation
                {
                    CalculationID = 1,
                    Value1 = 5,
                    Value2 = 3,
                    Operation = "+",
                    Result = 8,
                    DateCalculated = DateTime.Now
                },
                new Calculation
                {
                    CalculationID = 2,
                    Value1 = 10,
                    Value2 = 2,
                    Operation = "/",
                    Result = 5,
                    DateCalculated = DateTime.Now
                }
            );
        }

        // Example connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-273ULK4\SQLEXPRESS;Database=CalculatorDb;Trusted_Connection=True;Encrypt=False;");
        }
    }
}
