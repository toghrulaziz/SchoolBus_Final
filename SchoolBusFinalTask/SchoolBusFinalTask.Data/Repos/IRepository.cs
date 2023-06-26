using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusFinalTask.Data.Repos
{
    public interface IRepository<T>
    {
        T? Get(int id, bool tracking = true);
        IEnumerable<T>? Get(Expression<Func<T, bool>> expression, bool tracking = true);
        IEnumerable<T>? GetAll(bool tracking = true);
        void Update(T entity);
        void Add(T entity);
        void AddRange(IEnumerable<T> entity);
        void Remove(T entity);
        void SaveChanges();

    }
}
