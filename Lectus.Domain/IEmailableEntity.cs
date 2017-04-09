using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectus.Domain
{
    public interface IEmailableEntity<T> : IEntity<T>
    {
        int? EmailTypeCode { get; set; }
        string Email { get; set; }
        byte? Show { get; set; }
    }

    public abstract class EmailableEntity<T> : BaseEntity, IEmailableEntity<T> 
    {
        public virtual T Id { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
        public virtual string UpdatedBy { get; set; }

        public int? EmailTypeCode { get; set; }
        public string Email { get; set; }
        public byte? Show { get; set; }
    }
}
