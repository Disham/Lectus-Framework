using System;
using Lectus.Domain.Models;
using Lectus.Domain;

namespace Lectus.Entity.Models
{
    public partial class MstBranchEmailDetail : EmailableEntity<int>
    {
        public int? BranchCode { get; set; }
        public byte? Active { get; set; }
        public virtual MstEmailType MstEmailType { get; set; }
    }
}
