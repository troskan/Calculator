using Calculator.Data;
using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        public void SaveCalculation(double num, double num2, double result, string operation)
        {
            Context _db = new Context();
            Calculation calc = new Calculation()
            {
                Value1 = num,
                Value2 = num2,
                Result = result,
                Operation = operation,
                DateCalculated = DateTime.Now
            };
            _db.Calculations.Add(calc);
            _db.SaveChanges();
        }
        public List<Calculation> GetCalculations()
        {
            Context _db = new Context();
            var calculations = _db.Calculations.ToList();

            return calculations;
        }

        public double Add(double num, double num2)
        {
            string operation = "+";
            double result = num + num2;
            
            SaveCalculation(num, num2, result, operation);
            
            return result;

        }
        public double Subtract(double num, double num2)
        {
            return num - num2;
        }
        public double Division(double num, double num2)
        {
            return num / num2;
        }
    }
}
