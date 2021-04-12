using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Db04.Web.ViewModels
{
    public class AccountViewModel
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsPinCorrect { get; set; }
    }
}
