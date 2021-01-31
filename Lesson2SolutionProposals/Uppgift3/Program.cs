using System;

namespace Uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in tal som ska omvandlas till olika enheter: ");
            string input = Console.ReadLine();
            double value = double.Parse(input);

            Console.WriteLine($"{value} meter = {Math.Round(value * 1.0936133, 2)} yards");
        }
    }
}
