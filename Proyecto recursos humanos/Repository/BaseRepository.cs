using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_recursos_humanos.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T: class
    {
        private readonly DBProyectoFinalContext _context;
        private readonly Microsoft.EntityFrameworkCore.DbSet<T> _dbSet;
        public BaseRepository(DBProyectoFinalContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public T Add(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public T FindById(long id)
        {
            return _dbSet.Find(id);
        }

        public List<T> GetAll()
        {
            return  _dbSet.ToList();
        }

        public List<T> GetAllByFilter(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public void Remove(T entity)
        {
            _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
       
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return entity;
        }
    }
}
