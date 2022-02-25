using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Persistance.Database;

namespace Common.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly ApplicationDbContext _context;
   
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var entity =  GetById(id);

            if (entity == null)
                throw new Exception("The entity is null");

            _context.Set<T>().Remove(entity);
             _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return  _context.Set<T>().ToList();
        }

        public  T GetById(int id)
        {
            return  _context.Set<T>().Find(id);
        }

        public  T Insert(T entity)
        {
            _context.Set<T>().Add(entity);
             _context.SaveChanges();
            return entity;
        }

        public  T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
             _context.SaveChanges();
            return entity;
        }
    }
}
