﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case.Repository
{
    public abstract class BaseRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        protected TContext _dbContext;
        protected DbSet<TEntity> _dbSet;

        public BaseRepository(TContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }


        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual TEntity Find(int Id)
        {
            return _dbSet.Find(Id);
        }

        public virtual IQueryable<TEntity> GetQuery()
        {
            return _dbSet.AsQueryable();
        }

        public virtual IQueryable GetSqlRawQuery(string query)
        {


            return _dbSet.AsQueryable();

        }

        public virtual void Remove(int Id)
        {
            var entity = Find(Id);
            _dbSet.Remove(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public virtual void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
