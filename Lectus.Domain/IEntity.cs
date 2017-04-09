using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectus.Domain
{

    public interface IEntity<T> : IAuditable
    {
        T Id { get; set; }         
    }

    public interface IAuditable
    {
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
    }

    public abstract class BaseEntity
    {

    }
    
    public abstract class Entity<T> : BaseEntity, IEntity<T> 
    {
        public virtual T Id { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
        public virtual string UpdatedBy { get; set; }
    }
}
