namespace ArrayUtilApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int[] dest = new int[arr.Length];

            Array.Copy(arr, dest, arr.Length);

            foreach (int el in dest)
            {
                Console.WriteLine(el + " ");
            }
        }
    }
}
