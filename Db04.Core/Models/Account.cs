using System;

namespace Db04.Core.Models
{
    public class Account
    {
        // fields
        private readonly int _pin;
        private readonly string _incorrectPinMessage = "Incorrect PIN";

        // properties
        public long Id { get; private set; }
        public string Name { get; private set; }
        public decimal Balance { get; private set; }


        // constructor
        private Account() { }

        public Account(string name, int pin = 12345)
        {
            Name = name;
            _pin = pin;
            Balance = 0M;
        }

        public string AddBalance(int pin, decimal amount)
        {
            if (!IsPinValid(pin)) return _incorrectPinMessage;
            
            Balance += amount;
            return GetSuccessMessage();
        }

        private bool IsPinValid(int pin)
        {
            return pin == _pin;
        }

        private string GetSuccessMessage() => $"Success. {Balance}";

        public virtual string Withdraw(int pin, decimal amount)
        {
            if (!IsPinValid(pin)) return _incorrectPinMessage;

            Balance -= amount;
            return GetSuccessMessage();
        }

        public decimal GetBalance(int pin)
        {
            if (!IsPinValid(pin)) throw new ArgumentException("PIN is invalid", nameof(pin));

            return Balance;
        }

        // methodes
    }
}
