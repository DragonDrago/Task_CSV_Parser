using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace Task_Csv_Importer.Data.Base
{
    /// <summary>
    /// Using Generic Methods is very useful to extend the porject, later if u need.
    /// For example later if u want to add another type of entity, and want to do the same operations,=>
    /// => you dont have to repeat yourself. Instead just inherit from generic classes and and use these methods.
    /// </summary>
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T>GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id,T entity);

    }
}
