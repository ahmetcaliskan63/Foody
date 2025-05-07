using Foody.DataAccsessLayer.Abstract;
using Foody.DataAccsessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccsessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly FoodyContext _context;
        public GenericRepository(FoodyContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var value = _context.Set<T>().Find(id);
            if (value != null)
            {
                _context.Set<T>().Remove(value);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Entity not found");
            }
        }

        public List<T> GetAll()
        {
            _context.Set<T>().ToList();
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            _context.Set<T>().Find(id);
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
