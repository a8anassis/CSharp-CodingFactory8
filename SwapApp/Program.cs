namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Console.WriteLine($"a={a}, b={b}");
            Swap(a, b);
            Console.WriteLine($"a={a}, b={b}");
        }

        public static void Swap(int a, int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static void SwapWithTuple(int a, int b)
        {
            (a, b) = (b, a);        // tuples
        }
    }
}
