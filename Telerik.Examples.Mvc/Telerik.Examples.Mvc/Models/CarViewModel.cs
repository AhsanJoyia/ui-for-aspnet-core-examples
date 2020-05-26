﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Telerik.Examples.Mvc.Models
{
    public class CarViewModel
    {
        public Guid Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public DateTime ProductionDate { get; set; }
    }
}
