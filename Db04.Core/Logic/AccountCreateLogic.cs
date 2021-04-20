using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db04.Core.Logic
{
    public class AccountCreateLogic
    {
        //private readonly ApplicationDbContext _context;

        //public AccountCreateLogic(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public void Create(string name, int pin)
        {
            var account = new Core.Models.Account(name, pin);

            //_context.Accounts.Add(account);
            //_context.SaveChanges();
        }
    }
}
