﻿using Microsoft.EntityFrameworkCore;
using SchoolBusFinalTask.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusFinalTask.Data.Repos
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly SchoolBusDbContext _context;
        private readonly DbSet<T> _dbSet;


        public Repository()
        {
            _context = new SchoolBusDbContext();
            _dbSet = _context.Set<T>();
        }


        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
        }

        public T? Get(int id, bool tracking = true)
        {
            if (tracking)
            {
                return _dbSet.FirstOrDefault(obj => obj.Id == id);
            }
            return _dbSet.AsNoTracking().FirstOrDefault(obj => obj.Id == id);
        }

        public IEnumerable<T>? Get(Expression<Func<T, bool>> expression, bool tracking = true)
        {
            if (tracking)
            {
                return _dbSet.Where(expression).ToList();
            }
            return _dbSet.AsNoTracking().Where(expression).ToList();
        }

        public IEnumerable<T>? GetAll(bool tracking = true)
        {
            if (tracking)
            {
                return _dbSet.ToList();
            }
            return _dbSet.AsNoTracking().ToList();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        
    }
}
