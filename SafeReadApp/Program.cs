namespace SafeReadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //decimal d1 = 0m;
            //decimal d2 = 0m;

            Console.WriteLine("Παρακαλώ εισάγετε δύο δεκαδικούς");

            if (!decimal.TryParse(Console.ReadLine(), out decimal d1)) 
            {
                Console.WriteLine("Error in input");
                return;
            }

            if (!decimal.TryParse(Console.ReadLine(), out decimal d2))
            {
                Console.WriteLine("Error in input");
                return;
            }

            Console.WriteLine($"d1: {d1}, d2: {d2}");
        }
    }
}
