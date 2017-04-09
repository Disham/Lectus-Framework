using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectus.Domain
{
    public interface IAddressableEntity<T> : IAddress
    {
        T Id { get; set; }
    }

    public interface IAddress
    {
        int? CountryCode { get; set; }
        int? StateCode { get; set; }
        int? CityCode { get; set; }
        int? AddressTypeCode { get; set; }
        string Address1 { get; set; }
        string Address2 { get; set; }
        string Pincode { get; set; }
        byte? IsMain { get; set; }
    }

    public abstract class AddressableEntity<T> : BaseEntity, IAddressableEntity<T>
    {
        public virtual T Id { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
        public virtual string UpdatedBy { get; set; }

        public virtual int? CountryCode { get; set; }
        public virtual int? StateCode { get; set; }
        public virtual int? CityCode { get; set; }
        public virtual int? AddressTypeCode { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string Pincode { get; set; }
        public virtual byte? IsMain { get; set; }
    }
}
