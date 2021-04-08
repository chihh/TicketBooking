using System;
using System.Collections.Generic;
using System.Text;
using DAL.Abstract;

namespace DAL.Repositories
{
    public class GenericRepository<TEntity, Tkey> : IRepository<TEntity, Tkey> where TEntity : class
    {
        public void Create(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tkey id)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Tkey id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
