using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Lectus.Domain;
using Lectus.Repository.UnitOfWork;

namespace Lectus.Repository.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        void SetUnitWork(IUnitOfWork uow);
        ICollection<T> GetAll();
        ICollection<T> FindBy(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}