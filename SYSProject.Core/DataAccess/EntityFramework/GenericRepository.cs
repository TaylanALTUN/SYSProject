using Microsoft.EntityFrameworkCore;
using SYSProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SYSProject.Core.DataAccess.EntityFramework
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
     where TEntity : class, IEntity, new()
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _entities;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _entities.ToList() : _entities.Where(filter).ToList();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _entities.FirstOrDefault(filter);
        }

        public bool Add(TEntity entity, long userId)
        {
            entity.CreatedBy = userId;
            entity.CreatedDate = DateTime.Now;
            _entities.Add(entity);
            return _context.SaveChanges() > 0;
        }

        public bool Update(TEntity entity, long userId)
        {
            entity.UpdatedBy = userId;
            entity.UpdatedDate = DateTime.Now;
            return _context.SaveChanges() > 0;
        }

        public bool Delete(TEntity entity, long userId)
        {
            entity.DeletedBy = userId;
            entity.DeletedDate = DateTime.Now;
            entity.IsDeleted = true;
            return _context.SaveChanges() > 0;
        }
    }
}