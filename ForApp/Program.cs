namespace ForApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Άθροισμα: {sum}");

            sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) continue;   // not even in sum 
                sum += i;
            }

            Console.WriteLine($"Άθροισμα Μονών: {sum}");
        }
    }
}
