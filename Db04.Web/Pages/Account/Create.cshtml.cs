using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Db04.Core.Logic;
using Db04.DataAccess;
using Db04.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Db04.Web.Pages.Account
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public AccountCreateViewModel Account { get; set; }

        private readonly AccountCreateLogic _createService;

        public CreateModel(AccountCreateLogic service)
        {
            _createService = service;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _createService.Create(Account.Name, Account.Pin);

            return RedirectToPage("./Overview");
        }
    }
}
