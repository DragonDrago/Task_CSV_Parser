using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Task_Csv_Importer.Models;

namespace Task_Csv_Importer.Data.EmployeeRopositories
{
    public interface IEmployeeRepository
    {
        // To make loosely coupled classes, and to write clean code we use interface segregation accoring to SOLID princeples, adn later to use dependency injection in our classes.
        void AddEntity(Employee employee);
       IEnumerable<Employee> GetAll();
       Employee GetById(int id);
       void Update(Employee employee);
    }
}
