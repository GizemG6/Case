﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case.Models
{
    public interface IVehicle
    {
        public string Id { get; set; }
        public string Color { get; set; }
    }
}
