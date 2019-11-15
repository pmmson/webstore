using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 22,
                Position = "инженер"
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Владислав",
                SurName = "Петров",
                Patronymic = "Иванович",
                Age = 35,
                Position = "слесарь"
            },
            new EmployeeView
            {
                Id = 3,
                FirstName = "Александр",
                SurName = "Сидоров",
                Patronymic = "Викторович",
                Age = 39,
                Position = "повар"
            }
        };

        public IActionResult Index()
        {
            return View(_employees);
        }

        public IActionResult Details(int id)
        {
            foreach(EmployeeView employee in _employees)
            {
                if (employee.Id == id)
                {
                    return View(employee);
                }
            }

            return Content("No data found");
        }
    }
}