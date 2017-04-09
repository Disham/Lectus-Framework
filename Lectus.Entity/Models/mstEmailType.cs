using System;
using System.Collections.Generic;
using Lectus.Domain.Models;
using Lectus.Domain;

namespace Lectus.Entity.Models
{
    public partial class MstEmailType : Entity<int>
    {
        
        public MstEmailType()
        {
            this.MstBranchEmailDetails = new List<MstBranchEmailDetail>();
        }

        public string Type { get; set; }

        public virtual ICollection<MstBranchEmailDetail> MstBranchEmailDetails { get; set; }
    }
}
