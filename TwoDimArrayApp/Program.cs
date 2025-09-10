namespace TwoDimArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                { 1, 2, 3, 4, 5},
                { 2, 3, 4, 6, 7},
                { 3, 4, 5, 6, 7},
            };


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }



            int[][] jagged = new int[2][];
            jagged[0] = new int[4] { 1, 2, 3, 4 };
            jagged[1] = new int[5] { 2, 3, 4, 5, 6 };

            foreach (int[] row in jagged)
            {
                foreach (int item in row)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
