using AccountApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
    internal class Account
    {
        public long Id { get; set; }
        public string? Iban { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Ssn { get; set; }
        public decimal Balance { get; set; }

        public override string ToString() => $"{Id} {Iban} {Firstname} {Lastname} {Ssn} {Balance}";

        // Public API

        /// <summary>
        /// Deposits an amount of money to the <see cref="Account"/>.
        /// </summary>
        /// <param name="amount">The amount of money to withdraw.</param>
        public void Deposit(decimal amount)
        {
            try
            {
                if (amount < 0)
                    throw new NegativeAmountException($"Amount {amount} must not be negative.");
                Balance += amount;
            }
            catch (NegativeAmountException e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public void Withdraw(decimal amount, string? ssn)
        {
            try
            {
                if (string.IsNullOrEmpty(ssn))
                    throw new InvalidSsnException($"Ssn {ssn} must not be null or empty");
                if (!string.Equals(ssn, Ssn))
                    throw new InvalidSsnException($"Ssn {ssn} is not equal to the owner's ssn.");
                if (amount < 0) throw new NegativeAmountException();
                if (amount > Balance) throw new InsufficientAmountException();
                Balance -= amount;
            }
            catch (Exception e) when (e is NegativeAmountException || e is InvalidSsnException)
            {
                Console.Error.WriteLine($"{e.Message}");
                throw;
            }

            //catch (NegativeAmountException e) 
            //{
            //    Console.Error.WriteLine($"{e.Message}");
            //    throw;
            //}
            //catch (InvalidSsnException e)
            //{
            //    Console.Error.WriteLine($"{e.Message}");
            //    throw;
            //}
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }

}
