using System;
using System.Collections.Generic;
using Lectus.Domain.Models;
using Lectus.Domain;

namespace Lectus.Entity.Models
{
    public partial class MstAddressType : Entity<int>
    {
        public MstAddressType()
        {
            this.MstBranchAddressDetails = new List<MstBranchAddressDetail>();
        }
        public string Type { get; set; }
        public virtual ICollection<MstBranchAddressDetail> MstBranchAddressDetails { get; set; }
    }
}
