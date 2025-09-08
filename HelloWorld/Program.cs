using System;

namespace HelloWorld
{

    /// <summary>
    /// My first C# Program!
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, World!");
            Console.WriteLine();

            /*
             * Alternative output formats
             */

            string s = "World";
            Console.WriteLine("Hello, {0}!", s);  // Placeholder

            Console.WriteLine($"Hello, {s}!");    // Interpolation
        }
    }
}
