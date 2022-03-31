using System;

namespace GithubActionsLab
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Quick Calculator");
            var loop = true;
            while (loop)
            {
                try
                {
                    Func<string, string, double> operation = null;
                    Console.WriteLine("1) Add (x+y)");
                    Console.WriteLine("2) Subtract (x-y)");
                    Console.WriteLine("3) Multiply (x*y)");
                    Console.WriteLine("4) Divide (x/y)");
                    Console.WriteLine("5) Power (x^y)");
                    Console.WriteLine("6) Quit");
                    var operationSelection = GetInput("Select your operation: ");
                    switch (operationSelection)
                    {
                        case "1":
                            operation = Add_Hoyt;
                            break;
                        case "2":
                            operation = Subtract_Hoyt;
                            break;
                        case "3":
                            operation = Multiply_Hoyt;
                            break;
                        case "4":
                            operation = Divide_Hoyt;
                            break;
                        case "5":
                            operation = Power_Hoyt;
                            break;
                        case "6":
                            loop = false;
                            continue;
                        default:
                            throw new ArgumentException("You did not select a valid option!");
                    }

                    var x = GetInput("Enter x: ");
                    var y = GetInput("Enter y: ");
                    var result = operation(x, y);
                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().Trim();
        }

        public static double Add_Hoyt(string x, string y)
        {
            return double.Parse(x) + double.Parse(y);
        }

        public static double Subtract_Hoyt(string x, string y)
        {
            return double.Parse(x) - double.Parse(y);
        }
        public static double Multiply_Hoyt(string x, string y)
        {
            return double.Parse(x) * double.Parse(y);
        }
        public static double Divide_Hoyt(string x, string y)
        {
            return double.Parse(x) / double.Parse(y);
        }

        // Implement this method following a similar pattern as above
        public static double Power_Hoyt(string x, string y)
        {
            return Math.Pow(double.Parse(x), double.Parse(y));
        }
    }



}
