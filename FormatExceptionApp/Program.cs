namespace FormatExceptionApp
{
    /// <summary>
    /// Διαβάζει ένα stirng εισόδοτ και προσπαθεί
    /// να μετετρέψει σε int και ελέγχει με try/catch
    /// για FormatExcpetion
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;

            while (true)
            {
                try
                {
                    Console.WriteLine("Παρακαλώ εισάγετε ένα ακέραιο (0 για έξοδο)");
                    num = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Εισάγατε τον ακέραιο: {num}");
                    if (num == 0) break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
