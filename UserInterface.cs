using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static public class UserInterface
    {
        static Calculator calculator = new Calculator();

        static public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n\nCalculator Application: ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Show all calculations");
                Console.WriteLine("6. Exit");

                Console.Write("Choose an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                double num1 = 0, num2 = 0;

                if (choice >= 1 && choice <= 4)
                {
                    Console.Write("Enter first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Result: " + calculator.Add(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("Result: " + calculator.Subtract(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Result: " + calculator.Multiply(num1, num2));
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                        else
                        {
                            Console.WriteLine("Result: " + calculator.Division(num1, num2));
                        }
                        break;
                    case 5:
                        calculator.DisplayAllCalculations();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}
