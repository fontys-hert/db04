using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Db04.Web.ViewModels
{
    public class AccountCreateViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Pin { get; set; }
    }
}
