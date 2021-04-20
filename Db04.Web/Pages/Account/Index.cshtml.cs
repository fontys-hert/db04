using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Db04.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Db04.Web.Pages.Account
{
    public class IndexModel : PageModel
    {
        private readonly Core.Models.Account _account;

        public IndexModel()
        {
            _account = new Core.Models.Account("Timo");
            _account.AddBalance(12345, 50);
        }

        public AccountViewModel Account { get; set; }

        public void OnGet()
        {
            Account = new AccountViewModel
            {
                Balance = 0M, // todo: vervangen met pin invoerveld
                ErrorMessage = null,
                IsPinCorrect = false,
                Name = _account.Name
            };
        }

        public void OnPost(int pin)
        {
            string errorMessage = null;
            bool isPinCorrect = true;
            decimal balance = 0M;

            try
            {
                balance = _account.GetBalance(pin);
            } catch(ArgumentException exception)
            {
                if (exception.ParamName == "pin")
                {
                    isPinCorrect = false;
                    errorMessage = "PIN is niet correct";
                }
            }

            Account = new AccountViewModel
            {
                Balance = balance,
                ErrorMessage = errorMessage,
                IsPinCorrect = isPinCorrect,
                Name = _account.Name
            };
        }
    }
}
