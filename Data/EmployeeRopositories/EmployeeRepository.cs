
using System.Collections.Generic;
using System.Threading.Tasks;
using Task_Csv_Importer.Models;

namespace Task_Csv_Importer.Data.EmployeeRopositories
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public  void AddEntity(Employee employee)
        {
            appDbContext.Add(employee);
            appDbContext.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            var employees = appDbContext.Employees;
            return employees;
        }

        public Employee GetById(int id)
        {
            return appDbContext.Employees.Find(id);
        }

        public void Update(Employee updateEmployee)
        {
            var employee = appDbContext.Employees.Attach(updateEmployee);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            appDbContext.SaveChanges();
        }
    }
}
