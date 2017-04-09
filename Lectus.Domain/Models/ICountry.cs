using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectus.Domain.Models
{
    public class ICountry : Entity<int>
    {
        public string Name { get; set; }
        public byte? Active { get; set; }
    }
}
