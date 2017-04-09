using System;
using System.Collections.Generic;
using Lectus.Domain.Models;
using Lectus.Domain;

namespace Lectus.Entity.Models
{
    public partial class MstState : Entity<int>
    {
        
        public MstState()
        {
            this.MstBranchAddressDetails = new List<MstBranchAddressDetail>();
            this.MstCities = new List<MstCity>();
        }

        public int? CountryCode { get; set; }
        public string Name { get; set; }
        public byte? Active { get; set; }

        public virtual ICollection<MstBranchAddressDetail> MstBranchAddressDetails { get; set; }
        public virtual ICollection<MstCity> MstCities { get; set; }
        public virtual MstCountry MstCountry { get; set; }
    }
}
