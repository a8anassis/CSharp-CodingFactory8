using System.Numerics;

namespace BigIntegerApp
{
    /// <summary>
    /// Υπολογίζει το γινόμενο 1*2*3*...n
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            BigInteger result = 1;  // auto-boxing και υπερφόρτωση του = για big integers
            int i = 1;

            while (i <= n)
            {
                result *= i;
                i++;
            }

            Console.WriteLine($"1 * 2 * 3 * ... * {n} = {result:N0}");
        }
    }
}
