using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T entity)
        {
            using var _context = new Context();
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            using var _context = new Context();
            return _context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var _context = new Context();
            return _context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            using var _context = new Context();
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            using var _context = new Context();
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
