using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db04.Core
{
    public class SavingsAccount : Models.Account // OO principes: inheritance
    {
        public SavingsAccount(string name, int pin = 12345) 
            : base(name, pin)
        {
        }

        public override string Withdraw(int pin, decimal amount)
        {
            throw new InvalidOperationException("Jammer joh");
        }
    }
}
