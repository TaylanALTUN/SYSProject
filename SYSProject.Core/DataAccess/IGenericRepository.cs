using SYSProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SYSProject.Core.DataAccess
{
    public interface IGenericRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        bool Add(T entity, long userId);

        bool Update(T entity, long userId);

        bool Delete(T entity, long userId);
    }
}