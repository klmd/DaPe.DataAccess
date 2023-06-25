using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DaPe.DataAccess.Repository
{
    public interface IRepository<T> where T : class
    {
        //T = Category
        public IEnumerable<T> GetAll(string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
        public void Add(T entity);
        public void Remove(T entity);
        public void RemoveRange(IEnumerable<T> entity);
    }
}
