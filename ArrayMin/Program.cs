namespace ArrayMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 15, 25, 12, 55 };
            int minPosition = 0;

            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < ages[minPosition])
                {
                    minPosition = i;
                }
            }

            Console.WriteLine($"Min Value: {ages[minPosition]}, Min Position: {minPosition + 1}");
        }
    }
}
