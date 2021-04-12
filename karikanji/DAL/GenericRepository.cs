using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace karikanji.DAL
{
    public class GenericRepository
    {
         private readonly Context _context ;

         public GenericRepository()
        {
            _context = new Context();
        }

        public IEnumerable<T> GetAll<T>(Expression<Func<T, bool>> condition = null) where T : class
        {
            return condition != null ? _context.Set<T>().Where(condition) : _context.Set<T>();
        }

        public T Get<T>(Expression<Func<T, bool>> match) where T : class
        {
            return _context.Set<T>().SingleOrDefault(match);
        }

        public T Update<T>(T updated) where T : class
        {
            if (updated == null) return null;
            _context.Entry(updated).State = System.Data.Entity.EntityState.Modified;
            return updated;
        }

        public void Delete<T>(T model) where T : class
        {
            _context.Set<T>().Remove(model);
        }

        public T Add<T>(T model) where T : class
        {
            return _context.Set<T>().Add(model);
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}