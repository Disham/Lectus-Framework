using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectus.Domain
{
    public interface IContactableEntity<T> : IEntity<T>
    {
        int? ContactTypeCode { get; set; }
        string Number { get; set; }
        byte? Show { get; set; }
    }

    public abstract class ContactableEntity<T> : BaseEntity, IContactableEntity<T>
    {
        public virtual T Id { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
        public virtual string UpdatedBy { get; set; }

        public virtual int? ContactTypeCode { get; set; }
        public virtual string Number { get; set; }
        public virtual byte? Show { get; set; }

    }
}
