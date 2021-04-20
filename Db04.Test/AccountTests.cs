using Db04.Core;
using Db04.Core.Models;
using System;
using Xunit;

namespace Db04.Test
{
    public class AccountTests
    {
        [Fact]
        public void Creates_an_account_with_name_and_pin()
        {
            // arrange
            // act
            var account = new Account("Boris", 4321);

            // assert
            Assert.Equal("Boris", account.Name);
        }

        // Mogelijk voor een rekening om geld te storten als de pincode correct wordt ingevoerd.
        // Er wordt een bericht getoond van de nieuwe balans.
        // Als de pincode incorrect is volgt een bericht dat de pincode niet correct is.
        [Fact]
        public void Adds_balance_with_a_correct_pin()
        {
            // arrange
            var account = new Account("Damian", 1234);

            // act
            var message = account.AddBalance(1234, 39.98M);

            // arrange
            Assert.Equal("Success. 39.98", message);
        }

        [Fact]
        public void Adds_balance_with_a_correct_default_pin()
        {
            // arrange
            var account = new Account("Damian");

            // act
            var message = account.AddBalance(12345, 39.98M);

            // arrange
            Assert.Equal("Success. 39.98", message);
        }

        [Fact]
        public void Shows_an_incorrect_pin_error_when_trying_to_add_balance()
        {
            // arrange
            var account = new Account("Teun", 11111);

            // act
            var message = account.AddBalance(22222, 45.99M);

            // arrange
            Assert.Equal("Incorrect PIN", message);
        }

        // incorrect pin with default pin
        // default pin length? 1. Navragen aan de klant/docent 2. Aanname maken en implementeren

        // - Geld op te nemen als de pincode correct wordt ingevoerd.
        // Er wordt een bericht getoond van de nieuwe balans.
        // Als de pincode incorrect is volgt een bericht dat de pincode niet correct is.
        [Fact]
        public void Withdraws_amount_with_a_correct_pin()
        {
            // arrange
            var account = new Account("Damian", 1234);
            account.AddBalance(1234, 39.98M);

            // act
            var message = account.Withdraw(1234, 39.98M);

            // arrange
            Assert.Equal("Success. 0.00", message);
        }
        // waarom moet men een bericht terugsturen en niet gewoon het amount? Vragen aan klant/docent
        // kan ik minder dan balans opnemen?

        // Het is ook mogelijk om een spaar- en betaal rekening te openen.
        // De spaarrekening kan geen geld opnemen en geeft een error als de gebruiker dit probeert.
        // boolean/enum isSpaarRekening

        [Fact]
        public void Shows_an_error_when_savings_account_tries_to_withdraw_amount()
        {
            // arrange
            var account = new SavingsAccount("Timo");

            // act, assert
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(12345, 10M));
        }

        [Fact]
        public void Gets_the_balance_after_supplying_a_valid_pin()
        {
            var account = new Account("Timo");
            account.AddBalance(12345, 50);

            var balance = account.GetBalance(12345);

            Assert.Equal(50, balance);
        }
    }
}
