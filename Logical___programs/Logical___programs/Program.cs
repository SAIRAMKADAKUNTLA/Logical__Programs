using System;

namespace Logical___programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical problems");
            Console.WriteLine("1.Fibonacci,2.Prime,3.Reverse,4.Perfect");
            Console.WriteLine("Enter your Choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.Check();
                    break;
                case 2:
                    Prime prime = new Prime();
                    prime.Check();
                    break;
                case 3:
                    Reverse reverse = new Reverse();
                    reverse.check();
                    break;
                case 4:
                    Perfect perfect = new Perfect();
                    perfect.Check();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");

            }
        }
    }


