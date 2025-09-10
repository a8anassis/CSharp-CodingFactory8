using System.Diagnostics;

namespace NullableStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? s1 = null;     // non-nullable warning
            string? s2 = null;      // nullable

            s1 = Console.ReadLine()!; // non-nullable warning
            s2 = Console.ReadLine(); // nullable

            if ((s1 != null) && s1.Equals("Coding") && (s2 != null) && s2!.Equals("Coding")) 
            {
                Console.WriteLine("Bingo");
            }
        }

        public static string? GetUpperString(string? s)
        {
            return s?.ToUpper();        // null-Conditional Operator
        }

        public static string GetUpperString2(string? s)
        {
            return s?.ToUpper() ?? "NULL";        // Coalescing Operator
        }
    }
}
