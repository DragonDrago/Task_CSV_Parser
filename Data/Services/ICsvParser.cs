using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task_Csv_Importer.Models;
using Microsoft.AspNetCore.Http;

namespace Task_Csv_Importer.Data.Services
{
    public interface ICsvParser
    {
       IEnumerable<Employee> CsvParser (IFormFile formFile);
    }
}
