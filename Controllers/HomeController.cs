using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Task_Csv_Importer.Data.EmployeeRopositories;
using Task_Csv_Importer.Data.Services;
using Task_Csv_Importer.Models;

namespace Task_Csv_Importer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeRepository employeeRepository;
        private readonly ICsvParser csvParser;

        public HomeController(ILogger<HomeController> logger, IEmployeeRepository employeeRepository, ICsvParser csvParser)
        {
            _logger = logger;
            this.employeeRepository = employeeRepository;
            this.csvParser = csvParser;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddingCsvFile(IFormFile csv_file)
        {
            int rowCount = 0;
            var listEmployees = csvParser.CsvParser(csv_file);
            List<Employee> employees = listEmployees.OrderBy(n => n.Surname).ToList();
            foreach (var employee in employees)
            {
                employeeRepository.AddAsync(employee);
                rowCount++;
            }

            return View(rowCount);
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
