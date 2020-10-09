using System;
using System.Reflection;

namespace Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }
        
        static void Run() {
            
            double firstNumber = 0;
            double secondNumber = 0;
            
            Console.WriteLine("Console Calculator\r");
            Console.WriteLine("------------------\n");
            
            Console.WriteLine("Type a number and press Enter");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Type a second number & press Enter");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Choose an operator:");
            Console.WriteLine("\t1 - Addition");
            Console.WriteLine("\t2 - Subtraction");
            Console.WriteLine("\t3 - Multiplication");
            Console.WriteLine("\t4 - Division");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Result: {firstNumber} + {secondNumber} = " + (firstNumber + secondNumber));
                    break;
                case "2":
                    Console.WriteLine($"Result: {firstNumber} - {secondNumber} = " + (firstNumber - secondNumber));
                    break;
                case "3":
                    Console.WriteLine($"Result: {firstNumber} * {secondNumber} = " + (firstNumber * secondNumber));
                    break;
                case "4":
                    while (secondNumber == 0)
                    {
                        Console.WriteLine("Cannot divide by 0. Enter another number");
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Result: {firstNumber} / {secondNumber} = " + (firstNumber / secondNumber));
                    break;
            }
            
            Console.WriteLine("Press a key to exit or R to make another calculation");
            var next = Console.ReadKey();
            if (next.Key == ConsoleKey.R)
            {
                Run();
            }
        }
    }
}