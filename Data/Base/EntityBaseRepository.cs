﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;
namespace Task_Csv_Importer.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase,  new()
    {
        private readonly AppDbContext appDbContext;

        public EntityBaseRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task AddAsync(T entity)
        {
            await appDbContext.Set<T>().AddAsync(entity);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await appDbContext.Set<T>().ToListAsync();
            return result;
        }

        public async Task<T> GetByIdAsync(int id)
        {
           var result = await appDbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public Task UpdateAsync(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}