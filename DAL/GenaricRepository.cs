using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class GenaricRepository<T> : IGenaricRepository<T> where T : BaseModel
    {
        private readonly TaskDbContext _context;
        public GenaricRepository(TaskDbContext context)
        {
            this._context = context;
        }
        public T Create(T model)
        {
            var result = this._context.Set<T>().Add(model);
            return result.Entity;
        }

        public void Delete(int Id)
        {
            _context.Set<T>().Remove(_context.Find<T>(Id));
        }

        public IEnumerable<T> GetAll(params string[] Includes)
        {
            var List = _context.Set<T>().AsQueryable<T>();
            foreach (var item in Includes)
            {
                List = List.Include(item);
            }
            return List;
        }

        public T GetAllID(int Id)
        {
            return _context.Find<T>(Id);
        }

        public IEnumerable<T> Search(Func<T, bool> Condition, params string[] Includes)
        {
            return GetAll(Includes).AsQueryable<T>().Where(Condition);
        }

        public void Update(T model)
        {
            _context.Entry(model).State = EntityState.Modified;
        }
    }
}
