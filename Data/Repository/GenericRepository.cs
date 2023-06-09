﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingApplication.Data.Repository.Interface;
using TrainingApplication.Entities;

namespace TrainingApplication.Data.Repository
{
    public class GenericRepository<T> : IGenericRepo<T> where T : BaseEntity
    {

        private readonly DataContext dataContext;

        public GenericRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dataContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetInsurnaceDetail(int id)
        {
            return await dataContext.Set<T>().SingleOrDefaultAsync(x => x.Id == id);
        }
    }

}

