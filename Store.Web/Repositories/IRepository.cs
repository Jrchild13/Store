using Store.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Store.Repositories
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T UpDate(T entity);
        T Get(Guid Id);
        void SaveChanges();
    }
}
