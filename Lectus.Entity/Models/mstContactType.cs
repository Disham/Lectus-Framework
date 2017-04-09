using System;
using System.Collections.Generic;
using Lectus.Domain.Models;
using Lectus.Domain;

namespace Lectus.Entity.Models
{
    public partial class MstContactType : Entity<int>
    {
        
        public MstContactType()
        {
            this.MstBranchContactDetails = new List<MstBranchContactDetail>();
        }

        public string Type { get; set; }
        public virtual ICollection<MstBranchContactDetail> MstBranchContactDetails { get; set; }
    }
}
