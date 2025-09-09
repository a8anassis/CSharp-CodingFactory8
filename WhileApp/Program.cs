namespace WhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            const int END = 10;


            while (i < END)
            {
                sum += i;
                i++;
            }

            Console.WriteLine($"Το άθροισμα είναι: {sum}");
        }
    }
}
