using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectus.Domain.Models
{
    public class IState : Entity<int>
    {
        public int? CountryCode { get; set; }
        public string Name { get; set; }
        public byte? Active { get; set; }
    }
}
