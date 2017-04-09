using System;
using System.Collections.Generic;
using Lectus.Domain.Models;
using Lectus.Domain;

namespace Lectus.Entity.Models
{
    public partial class MstCity : Entity<int>
    {
       
        public MstCity()
        {
            this.MstBranchAddressDetails = new List<MstBranchAddressDetail>();
        }

        public int? StateCode { get; set; }
        public string Name { get; set; }
        public byte? Active { get; set; }

        public virtual ICollection<MstBranchAddressDetail> MstBranchAddressDetails { get; set; }
        public virtual MstState MstState { get; set; }
    }
}
