using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevOpsDemo.Models;
using DevOpsDemo.Repository;

namespace DevOpsDemo.Controllers
{
    public class HomeController : Controller
    {
        IEmployeeRepository EmployeeRepository;
        public HomeController(IEmployeeRepository _EmployeeRepository)
        {
            EmployeeRepository = _EmployeeRepository;
        }

        public IActionResult Index()
        {
            var model = EmployeeRepository.GetEmployees();

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
