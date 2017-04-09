using System;
using System.Collections.Generic;
using Lectus.Domain.Models;
using Lectus.Domain;

namespace Lectus.Entity.Models
{
    public partial class MstBranchContactDetail : ContactableEntity<int>
    {
        public int? BranchCode { get; set; }
        public byte? Active { get; set; }
        public virtual MstBranch MstBranch { get; set; }
        public virtual MstContactType MstContactType { get; set; }
    }
}
