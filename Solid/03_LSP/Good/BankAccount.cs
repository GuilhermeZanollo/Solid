using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._03_LSP.Good
{
    public class BankAccount
    {
        public decimal Balance { get; protected set; }

        public abstract void Withdraw(decimal amount);
    }

    public class CheckingAccount : BankAccount
    {
        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }

    public class SavingsAccount : BankAccount
    {
        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
