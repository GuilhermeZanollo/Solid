using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._03_LSP.Bad
{
    public class Bankaccount
    {
        public virtual void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdraw {amount}");
        }
    }

    public class SavingsAccount : Bankaccount
    {
        public decimal Balance { get; set; }

        public override void Withdraw(decimal amount)
        {
            if (Balance < amount)
                throw new Exception("Insufficiente balance");

            Balance -= amount;
            Console.WriteLine($"Withdraw {amount}");
        }   
    }
}
