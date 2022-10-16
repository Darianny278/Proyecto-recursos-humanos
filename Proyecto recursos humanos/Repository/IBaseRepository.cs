using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_recursos_humanos.Repository
{
    public interface IBaseRepository<T> where  T: class
    {
        List<T> GetAll();
        List<T> GetAllByFilter(Expression<Func<T, bool>> predicate);
        T FindById(long id);
        T Add(T entity);
        T Update(T entity);
        void Remove(T entity);

    }
}
