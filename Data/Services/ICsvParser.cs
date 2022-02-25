using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task_Csv_Importer.Models;
using Microsoft.AspNetCore.Http;

namespace Task_Csv_Importer.Data.Services
{
    // To make loosely coupled classes, and to write clean code we use interface segregation accoring to SOLID princeples, adn later to use dependency injection in our classes.
    public interface ICsvParser
    {
       IEnumerable<Employee> CsvParser (IFormFile formFile);
    }
}
