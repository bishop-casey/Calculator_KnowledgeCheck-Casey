using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static bool Getnumbers(string CalFun, out int num1, out int num2)
        {
            Console.WriteLine("Enter 2 integers to " + CalFun);
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();

            if (int.TryParse(number1, out int num1temp) && int.TryParse(number2, out int num2temp))
            {
                num1 = num1temp;
                num2 = num2temp;
                return true;

            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
                num1 = 0;
                num2 = 0;
                return false;

            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    var success = Getnumbers("add", out int num1, out int num2);
                    if (success == true)

                    {
                        Console.Write($"{num1} + {num2} = ");
                        Console.Write(calculator.Add(num1, num2));
                    }
                    break;

                case "2":
                    success = Getnumbers("add", out int subnum1, out int subnum2);
                    if (success == true)

                    {
                        Console.Write($"{subnum1} - {subnum2} = ");
                        Console.Write(calculator.Subtract(subnum1, subnum2));
                    }
                    break;

                case "3":
                    success = Getnumbers("add", out int mulnum1, out int mulnum2);
                    if (success == true)

                    {
                        Console.Write($"{mulnum1} * {mulnum2} = ");
                        Console.Write(calculator.Multiply(mulnum1, mulnum2));
                    }
                    break;

                case "4":
                    success = Getnumbers("add", out int divnum1, out int divnum2);
                    if (success == true)

                    {
                        Console.Write($"{divnum1} + {divnum2} = ");
                        Console.Write(calculator.Divide(divnum1, divnum2));
                    }
                    break;


                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}