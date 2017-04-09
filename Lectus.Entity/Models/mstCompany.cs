using System;
using System.Collections.Generic;
using Lectus.Domain.Models;
using Lectus.Domain;

namespace Lectus.Entity.Models
{
    public partial class MstCompany : Entity<int>
    {
       
        public MstCompany()
        {
            this.MstBranches = new List<MstBranch>();
        }
        public string Name { get; set; }
        public virtual ICollection<MstBranch> MstBranches { get; set; }
    }
}
