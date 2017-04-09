using System;
using System.Collections.Generic;
using Lectus.Domain.Models;
using Lectus.Domain;

namespace Lectus.Entity.Models
{
    [Serializable]
    public partial class MstCountry : Entity<int>
    {
        
        public MstCountry()
        {
            this.MstBranchAddressDetails = new List<MstBranchAddressDetail>();
            this.MstStates = new List<MstState>();
        }

        public string Name { get; set; }
        public byte? Active { get; set; }

        public virtual ICollection<MstBranchAddressDetail> MstBranchAddressDetails { get; set; }
        public virtual ICollection<MstState> MstStates { get; set; }
    }
}
