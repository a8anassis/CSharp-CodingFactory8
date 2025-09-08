using System.Text;

namespace EurosToDollars
{
    /// <summary>
    /// Διαβάζει από το std ένα ακέραιο που αναπαριστά
    /// το ποσό σε ευρώ. Και μετατρέπει από ευρώ σε δολλάρια,
    /// με βάση μία ισοτιμία έστω 1 Εωρώ = 1.07 USD.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal RATE = 1.07m;
            decimal totalCents;
            decimal totalDollars;
            decimal dollars;
            decimal cents;

            Console.WriteLine("Παρακαλώ εισάγετε το ποσό σε Ευρώ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal inputEuros)) 
            {
                Console.WriteLine("Error in input"); 
                return;
            }

            dollars = inputEuros * RATE;
            cents = dollars * 100 % 100;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"\u20AC {inputEuros:F2} αντιστοιχούν σε \u0024 {Math.Floor(dollars):F0} {cents:F0} cents");
        }
    }
}
