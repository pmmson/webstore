using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly List<EmployeeView> _Employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 22,
                Position = "консультант"
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Владислав",
                SurName = "Петров",
                Patronymic = "Иванович",
                Age = 35,
                Position = "товаровед"
            },
            new EmployeeView
            {
                Id = 3,
                FirstName = "Александр",
                SurName = "Сидоров",
                Patronymic = "Викторович",
                Age = 39,
                Position = "менеджер"
            }
        };

        public IActionResult Index()
        {
            return View(_Employees);
        }

        public IActionResult Details(int id)
        {
            var employee = _Employees.FirstOrDefault(e => e.Id == id);
            if (employee is null)
                return Content("No Data Found");

            return View(employee);
        }
    }
}