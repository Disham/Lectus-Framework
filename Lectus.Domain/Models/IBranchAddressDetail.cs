using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectus.Domain.Models
{
    public class IBranchAddressDetail : AddressableEntity<int>
    {
        public int? BranchCode { get; set; }
        public byte? Show { get; set; }
        public byte? Active { get; set; }
    }
}
