using Task_Csv_Importer.Data.Base;
using Task_Csv_Importer.Models;

namespace Task_Csv_Importer.Data.EmployeeRopositories
{
    public class EmployeeRepository:EntityBaseRepository<Employee>,IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext appDbContext)
            :base(appDbContext)
        {

        }
    }
}
