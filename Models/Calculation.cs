using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    internal class Calculation
    {
        [Key]
        public int CalculationID { get; set; }
        [Required]
        public double Value1 { get; set; }
        [Required]
        public double Value2 { get; set; }
        [Required]
        public string Operation { get; set; }
        [Required]
        public double Result { get; set; }
        [Required]
        public DateTime DateCalculated { get; set; } = DateTime.Now;
    }
}
