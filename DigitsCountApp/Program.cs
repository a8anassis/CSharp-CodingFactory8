namespace DigitsCountApp
{
    /// <summary>
    /// Μετράει τον αριθμό των ψηφίων ενός ακεραίου που δίνει ο χρήστης.
    /// Για παράδειγμα το 135 -> 3
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempNum = 0;
            int digits = 0;

            Console.WriteLine("Παρακαλώ εισάγετε ένα ακέραιο");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Λάθος κατά την εισαγωγή");
                return;
            }

            tempNum = num;

            do
            {
                tempNum /= 10;
                digits++;
            } while (tempNum > 0);

            Console.WriteLine($"Digits count: {digits}");
        }
    }
}
