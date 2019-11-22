using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class EmployeeView
    {
        public int Id { get; set; }

        [Display(Name = "Имя")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        [StringLength(maximumLength:200,ErrorMessage = "Имя не может быть меньше 2х и больше 200 символов",MinimumLength = 2)]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        public string SurName { get; set; }

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Display(Name = "Возраст")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        public int Age { get; set; }

        [Display(Name = "Должность")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        public string Position { get; set; }
    }
}
