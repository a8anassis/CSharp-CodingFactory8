namespace EnhancedForApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Athens", "London", "Paris" };

            foreach (string city in cities)
            {
                Console.Write(city + " ");
            }
        }
    }
}
