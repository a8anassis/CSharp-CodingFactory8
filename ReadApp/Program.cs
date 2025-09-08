using System;

namespace ReadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float f = 0.0f;
            double d = 0d;

            Console.WriteLine("Παρακαλώ εισάγετε δύο δεκαδικούς");
            f = float.Parse(Console.ReadLine()!);
            d = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"f = {f:N2}\td = {d:N2}");
        }
    }
}
