using System;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in det första av tre decimaltal: ");
            string input = Console.ReadLine();
            double decimal1 = double.Parse(input);

            Console.Write("Mata in det andra av tre decimaltal: ");
            input = Console.ReadLine();
            double decimal2 = double.Parse(input);

            Console.Write("Mata in det tredje av tre decimaltal: ");
            input = Console.ReadLine();
            double decimal3 = double.Parse(input);

            double sum = decimal1 + decimal2 + decimal3;
            Console.WriteLine($"Summan av de tre talen är: {sum}");

            double average = sum / 3.0;
            Console.WriteLine($"Medelvärdet av de tre talen är: {average}");

            // Extra-uppgift:
            double integerPart = Math.Round(sum, 0);
            Console.WriteLine($"Sum rounded to the nearest integer: {integerPart}");
        }
    }
}
