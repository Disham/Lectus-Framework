﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectus.Domain.Models
{
    public class IContactType : Entity<int>
    {
        public string Type { get; set; }
    }
}