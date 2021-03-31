using System;

namespace Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! Welcome to la Calculator.");

            while(true)
            {
                float n1 = 0, n2 = 0;

                //numbers
                try
                {
                    Console.WriteLine("Enter a Number");
                    n1 = float.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Enter a Valid Number please");
                    continue;
                };

                try
                {
                    Console.WriteLine("Enter a Number");
                    n2 = float.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Enter a Valid Number please");
                    continue;
                };

                //operations
                Console.WriteLine("Enter an Operation");
                string operation = Console.ReadLine();

                switch(operation)
                {
                    case "+":
                        Console.WriteLine(n1 + " + " + n2 + " = " + (n1 + n2));
                        break;
                    case "-":
                        Console.WriteLine(n1 + " - " + n2 + " = " + (n1 - n2));
                        break;
                    case "*":
                        Console.WriteLine(n1 + " * " + n2 + " = " + (n1 * n2));
                        break;
                    case "/":
                        Console.WriteLine(n1 + " / " + n2 + " = " + (n1 / n2));
                        break;
                    default:
                        Console.WriteLine("Enter a Valid operation please");
                        break;

                }
                
                //Exit
                Console.WriteLine("if you want to exit the program, press E. If not press any other key");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.E)
                    return;
                //Line
                Console.WriteLine();
            }
        }
    }
}
