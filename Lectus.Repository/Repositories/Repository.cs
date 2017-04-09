﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lectus.Domain;

namespace Lectus.Repository.Repositories
{
    public class Repository<T>: IRepository<T> where T : BaseEntity
   {
       protected DbContext _entities;
       protected readonly IDbSet<T> _dbset;
 
       public Repository(DbContext context)
       {
           _entities = context;
           _dbset = context.Set<T>();
       }

       public virtual ICollection<T> GetAll()
       {
 
           return _dbset.ToList<T>();
       }

       public ICollection<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
       {
           ICollection<T> query = _dbset.Where(predicate).ToList(); 
           return query;
       }
 
       public virtual T Add(T entity)
       {
           return _dbset.Add(entity);
       }
 
       public virtual T Delete(T entity)
       {
           return _dbset.Remove(entity);
       }
 
       public virtual void Edit(T entity)
       {
           _entities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
       }
 
       public virtual void Save()
       {
           _entities.SaveChanges();
       }
   }
}
