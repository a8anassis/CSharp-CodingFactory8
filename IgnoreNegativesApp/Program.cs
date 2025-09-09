namespace IgnoreNegativesApp
{
    /// <summary>
    /// Μετράει το πλήθος των θετικών όσο το
    /// input δεν είναι μηδέν.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Παρακαλώ εισάγετε ένα ακέραιο");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Λάθος κατά την εισαγωγή");
                return;
            }

            while (num != 0)                // sentinel is 0
            {
                if (num > 0) count++;

                Console.WriteLine("Παρακαλώ εισάγετε ένα ακέραιο");
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Λάθος κατά την εισαγωγή");
                    return;
                }
            }

            Console.WriteLine($"Το πλήθος των θετικών είναι: {count}");
        }
    }
}
