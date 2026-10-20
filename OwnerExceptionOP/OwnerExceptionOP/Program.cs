using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnerExceptionOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Withdraw(100, 200);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Withdraw(decimal balance, decimal amount)
        {
            if (amount > balance)
            {
                throw new InsufficientFundsException(
                    "Insufficient funds."
                );
            }

            Console.WriteLine("Withdrawal successful");
        }
    }
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message)
            : base(message)
        {
        }
    }
}
