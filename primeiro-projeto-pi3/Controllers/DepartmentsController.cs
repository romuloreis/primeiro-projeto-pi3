using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using primeiro_projeto_pi3.Models;

namespace primeiro_projeto_pi3.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            //Instância uma lista de Department
            List<Department> list = new List<Department>();
            list.Add(new Department { IdDepartment=1, Name="Vendas"});
            list.Add(new Department { IdDepartment = 2, Name = "Esporte" });
            list.Add(new Department { IdDepartment = 3, Name = "Games" });

            //Passa uma lista de objetos para a View
            return View(list);
        }
    }
}