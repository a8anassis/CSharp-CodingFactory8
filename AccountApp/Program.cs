using AccountApp.Exceptions;
using AccountApp.Model;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new()
            {
                Id = 1,
                Iban = "GR123",
                Firstname = "Αθαν.",
                Lastname = "Ανδρούτσος",
                Ssn = "A12345",
                Balance = 1000
            };

            try
            {
                account.Deposit(100);
                // account.Withdraw(20, "A1234");
                account.Deposit(-10);
            }
            catch (Exception ex)
            {
                if (ex is NegativeAmountException
                    || ex is InsufficientAmountException || ex is InvalidSsnException)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Account: {account}");
        }
    }
}
