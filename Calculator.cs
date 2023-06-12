using Calculator.Data;
using Calculator.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public void SaveCalculation(double num, double num2, double result, string operation)
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine($"Error: Please try again." +
                    $"{e}");
            }
        }
        
        public List<Calculation> GetCalculations()
        {
            Context _db = new Context();
            var calculations = _db.Calculations.ToList();

            return calculations;
        }
        public void DisplayAllCalculations()
        {
            var calc = new Calculator();
            List<Calculation> list = calc.GetCalculations();
            foreach (var c in list)
            {
                Console.WriteLine($"ID #{c.CalculationID}: {c.Value1} {c.Operation} {c.Value2} = {c.Result} \t: Date Posted:{c.DateCalculated}");

            }
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
            string operation = "-";
            double result = num - num2;

            SaveCalculation(num, num2, result, operation);

            return result;

        }
    
        public double Division(double num, double num2)
        {
            string operation = "/";
            double result = num / num2;

            SaveCalculation(num, num2, result, operation);

            return result;

        }    
        public double Multiply(double num, double num2)
        {
            string operation = "*";
            double result = num * num2;

            SaveCalculation(num, num2, result, operation);

            return result;

        }
    }
}
