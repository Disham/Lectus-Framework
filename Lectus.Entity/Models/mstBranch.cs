using System;
using System.Collections.Generic;
using Lectus.Domain;

namespace Lectus.Entity.Models
{
    public partial class MstBranch : Entity<int>
    {
        
        public MstBranch()
        {
            this.MstBranchAddressDetails = new List<MstBranchAddressDetail>();
            this.MstBranchContactDetails = new List<MstBranchContactDetail>();
        }

        public int? CompanyCode { get; set; }
        public string Name { get; set; }
        public byte? Active { get; set; }

        public virtual MstCompany MstCompany { get; set; }
        public virtual ICollection<MstBranchAddressDetail> MstBranchAddressDetails { get; set; }
        public virtual ICollection<MstBranchContactDetail> MstBranchContactDetails { get; set; }
        
    }
}
