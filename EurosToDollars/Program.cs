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

            Console.WriteLine("Παρακαλώ εισάγετε το ποσό σε Ευρώ");

            if (!decimal.TryParse(Console.ReadLine(), out decimal inputEuros))
            {
                Console.WriteLine("Error in input");
                return;
            }

            // Μετατροπή σε δολάρια
            decimal converted = inputEuros * RATE;

            // Συνολικά cents (στρογγυλοποίηση για αποφυγή σφαλμάτων)
            int totalCents = (int)Math.Round(converted * 100, MidpointRounding.AwayFromZero); // Default MidpointRounding.ToEven

            int dollars = totalCents / 100;
            int cents = totalCents % 100;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"\u20AC {inputEuros:F2} αντιστοιχούν σε \u0024 {dollars} και {cents} cents");
        }
    }
}
