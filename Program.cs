using System;

namespace csharpCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculate = new Calculate();
            Console.WriteLine("Simple Calculator");

            while (true)
            {
                try
                {
                    Console.Write("Type your first number: ");
                    calculate.FirstNumber = double.Parse(Console.ReadLine());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }

                try
                {
                    Console.WriteLine("\tTo add enter: \t\t'+'");
                    Console.WriteLine("\tTo subtract enter: \t'-'");
                    Console.WriteLine("\tTo multiply enter: \t'*'");
                    Console.WriteLine("\tTo divide enter: \t'/'");
                    Console.Write("Enter operator: ");
                    calculate.Oper = Console.ReadLine();

                    if (calculate.Oper == "+" || calculate.Oper == "-" || calculate.Oper == "*" || calculate.Oper == "/")
                    {
                        Console.WriteLine(calculate.Oper);
                    }
                    else
                    {
                        Console.WriteLine("Invalid operator");
                        break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try
                {
                    Console.Write("Type your second number: ");
                    calculate.SecondNumber = double.Parse(Console.ReadLine());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }

                var evaluate = calculate.Evaluation();

                Console.WriteLine($"Your Answer: {evaluate}");
            }

            Console.WriteLine("Press Enter to quit");
            Console.ReadLine();
        }
    }
}
