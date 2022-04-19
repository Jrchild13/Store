using Store.Db.Models;
using System.Linq.Expressions;

namespace Store.Repositories
{
    public abstract class GenericRepository<T> 
        : IRepository<T> where T : class
    {

        protected StoreDbContext context;
        public GenericRepository(StoreDbContext context)
        {
            this.context = context;
        }
        public virtual T Add(T entity)
        {
            return context.Add(entity).Entity;
        }

        public virtual T Get(Guid Id)
        {
            return context.Find<T>(Id);
        }

        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }

        public virtual T UpDate(T entity)
        {
            return context.Update<T>(entity).Entity;
        }
    }
}
