using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Task_Csv_Importer.Models;

namespace Task_Csv_Importer.Data.SortingAndSearching
{
    public interface ISortingAndSearching
    {
        // To make loosely coupled classes, and to write clean code we use interface segregation accoring to SOLID princeples, adn later to use dependency injection in our classes.
        IEnumerable<Employee> ListForSortByAsc(string sortBy);
        IEnumerable<Employee> ListForSortByDesc(string sortBy);
        IEnumerable<Employee> ListForSearching(string searchString);

    }
}
