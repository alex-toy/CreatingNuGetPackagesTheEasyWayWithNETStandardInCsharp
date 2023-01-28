using AlexeiLib.Calculations;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = Calculator.Add(2, 3);
            Console.WriteLine(sum);

            double sub = Calculator.Substract(9, 7);
            Console.WriteLine(sub);
        }
    }
}
