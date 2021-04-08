using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Abstract
{
    public interface IRepository<TEntity, Tkey> where TEntity : class
    {
            IEnumerable<TEntity> GetAll();
            TEntity Get(Tkey id);
            //IEnumerable<TEntity> Find(Func<TEntity, Boolean> predicate);
            void Create(TEntity item);
            void Update(TEntity item);
            void Delete(Tkey id);
    }
}
