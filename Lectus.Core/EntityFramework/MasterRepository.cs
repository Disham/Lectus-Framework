using Lectus.Domain;
using Lectus.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Lectus.Repository.UnitOfWork;
using AutoMapper;

namespace Lectus.Core.EntityFramework
{
    internal class MasterRepository<T> : IRepository<T> where T : BaseEntity
    {
        private DbContext _dbContext = null;
        private readonly IDbSet<T> _dbset;
        public MasterRepository()
        {
            _dbContext = (DbContext)CoreDependancyResolver.Resolve<IUnitOfWork>();
            _dbset = _dbContext.Set<T>();
        }
        public ICollection<T> GetAll()
        {
            return _dbset.AsEnumerable().ToList();
        }

        public ICollection<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            ICollection<T> query = _dbset.Where(predicate).ToList();
            return query;
        }

        public T Add(T entity)
        {
            return _dbset.Add(entity);
        }

        public T Delete(T entity)
        {
            return _dbset.Remove(entity);
        }

        public void Edit(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void SetUnitWork(IUnitOfWork uow)
        {
            _dbContext = ((EFUOW)uow);
        }
    }
}
