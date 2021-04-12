using System;

namespace Db04.Core
{
    public class Account
    {
        // fields
        private readonly int _pin;
        private readonly string _incorrectPinMessage = "Incorrect PIN";
        private decimal _balance = 0M;

        // properties
        public string Name { get; }
        

        // constructor
        public Account(string name, int pin = 12345)
        {
            Name = name;
            _pin = pin;
        }

        public string AddBalance(int pin, decimal amount)
        {
            if (!IsPinValid(pin)) return _incorrectPinMessage;
            
            _balance += amount;
            return GetSuccessMessage();
        }

        private bool IsPinValid(int pin)
        {
            return pin == _pin;
        }

        private string GetSuccessMessage() => $"Success. {_balance}";

        public virtual string Withdraw(int pin, decimal amount)
        {
            if (!IsPinValid(pin)) return _incorrectPinMessage;

            _balance -= amount;
            return GetSuccessMessage();
        }

        public decimal GetBalance(int pin)
        {
            if (!IsPinValid(pin)) throw new ArgumentException("PIN is invalid", nameof(pin));

            return _balance;
        }

        // methodes
    }
}
