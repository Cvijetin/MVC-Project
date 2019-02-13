﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class VehicleModelDTO
    {
        public int Id { get; set; } // ID (Primary key)
        public string Name { get; set; }
        public string Abrv { get; set; }
        public VehicleMakeDTO Make { get; set; }
    }
}