using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models.Account
{
    public class LoginViewModel
    {
        [Display(Name = "Имя пользователя")]
        public string UserName { get; set; }

        [Display(Name = "Пароль")]
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
