using System;
using System.Collections.Generic;
using Lectus.Domain.Models;
using Lectus.Domain;

namespace Lectus.Entity.Models
{
    public partial class MstBranchAddressDetail : AddressableEntity<int>
    {
        public int? BranchCode { get; set; }
        public byte? Show { get; set; }
        public byte? Active { get; set; }

        public virtual MstAddressType MstAddressType { get; set; }
        public virtual MstBranch MstBranch { get; set; }
        public virtual MstCity MstCity { get; set; }
        public virtual MstCountry MstCountry { get; set; }
        public virtual MstState MstState { get; set; }
    }
}
