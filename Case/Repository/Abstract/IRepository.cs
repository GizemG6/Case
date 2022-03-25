using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case.Repository
{
    public interface IRepository<TEntity> where TEntity:class
    {
        void Add(TEntity entity);
        void Remove(int Id);
        void Update(TEntity entity);

        TEntity Find(int Id);

        IQueryable<TEntity> GetQuery();
 
        IQueryable GetSqlRawQuery(string query);

        void Save();
    }
}
