using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectus.Domain.Models
{
    public class ICity : Entity<int>
    {
        public int? StateCode { get; set; }
        public string Name { get; set; }
        public byte? Active { get; set; }
    }
}
