using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {

        public static void Main(string[] args)
        {
            bool stillgoing = true;
            Console.Write("Give a number:");
            double firstnumber = Convert.ToDouble(Console.ReadLine());

            while (stillgoing != false)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Operators: +, -, *, /, =");
                Console.WriteLine("-------------------------");
                Console.Write("Select an operator: ");
                string operators = Console.ReadLine();
                double secondnumber = 0;
                GetOperator(operators);
                if (operators != "!")
                {
                    if (operators != "=")
                    {
                        Console.WriteLine("-------------------------");
                        Console.Write("Give another number: ");
                        secondnumber = Convert.ToDouble(Console.ReadLine());
                    }
                }

                if (operators == "+")
                {
                    firstnumber += secondnumber;
                }
                else if (operators == "-")
                {
                    firstnumber -= secondnumber;
                }
                else if (operators == "*")
                {
                    firstnumber *= secondnumber;
                }
                else if (operators == "/")
                {
                    firstnumber /= secondnumber;
                }
                else if (operators == "=")
                {
                    break;
                }

            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Result = " + firstnumber);

        }

        static string GetOperator(string _operator)
        {
            string lastoperator;

            switch (_operator)
            {
                case "+":
                    lastoperator = "+";
                    break;
                case "-":
                    lastoperator = "-";
                    break;
                case "/":
                    lastoperator = "/";
                    break;
                case "*":
                    lastoperator = "*";
                    break;
                case "=":
                    lastoperator = "=";
                    break;
                default:
                    lastoperator = "!";
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("You picked an invalid operator please try again.");
                    break;
            }

            return lastoperator;
        }
    }
}