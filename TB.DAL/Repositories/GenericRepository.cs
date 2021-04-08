using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using TB.DAL.Abstract;

namespace TB.DAL.Repositories
{
    public class GenericRepository<TEntity, Tkey> : IRepository<TEntity, Tkey> where TEntity : class
    {
        private readonly TicketBookingContext context;
        protected readonly DbSet<TEntity> dbSet;

        public GenericRepository(TicketBookingContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public virtual void Create(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual TEntity Get(Tkey id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return dbSet;
        }
        public virtual void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified; // do norm update
        }

        public virtual void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
        }
    }
}
