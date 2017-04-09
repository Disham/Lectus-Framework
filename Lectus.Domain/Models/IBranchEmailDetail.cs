using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectus.Domain.Models
{
    public class IBranchEmailDetail : EmailableEntity<int>
    {
        public int? BranchCode { get; set; }
        public byte? Active { get; set; }
    }
}
