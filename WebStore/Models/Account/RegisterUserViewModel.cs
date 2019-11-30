using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models.Account
{
    public class RegisterUserViewModel
    {
        [Display(Name = "Имя пользователя")] //TODO: не работает отображение на форме имени
        [Required, MaxLength(256)]
        public string UserName { get; set; }

        [Display(Name = "Пароль")]
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Подтверждение пароля")]
        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [Display(Name = "E-mail пользователя")]
        public string UserEmailAddress { get; set; }

    }
}
