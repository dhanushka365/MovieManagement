using Microsoft.EntityFrameworkCore;
using MovieManagement.Data;
using System.Linq.Expressions;

namespace MovieManagement.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MovieContext _context;
        private readonly DbSet<T> _entities;

        public GenericRepository(MovieContext context) {

            _context = context ?? throw new ArgumentNullException(nameof(context));
            _entities = context.Set<T>();

        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void DeleteAll()
        {
            _context.Set<T>().RemoveRange(_context.Set<T>());
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
           return _context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
           return  _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
