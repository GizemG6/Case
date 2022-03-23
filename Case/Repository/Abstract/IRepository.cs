using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case.Repository
{
    public interface IRepository<TEntity> where TEntity:class
    {
        void Add(TEntity entity);
        void Remove(string Id);
        void Update(TEntity entity);

        TEntity Find(string Id);

        /// <summary>
        /// Linq query
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetQuery();
        /// <summary>
        /// Sql query
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        IQueryable GetSqlRawQuery(string query);

        void Save();
    }
}
