using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Exceptions
{
    internal class InvalidSsnException : Exception
    {
        public InvalidSsnException() : base("Invalid SSN format") 
        { 
        }
        public InvalidSsnException(string message) : base(message)
        {
        }
        public InvalidSsnException(string? message, Exception? innerException) 
            : base(message, innerException)
        {
        }
    }
}
