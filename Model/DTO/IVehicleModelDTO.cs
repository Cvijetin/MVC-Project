﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public interface IVehicleModelDTO
    {
        int Id { get; set; }
        string Name { get; set; }
        string Abrv { get; set; }
        int MakeId { get; set; }
    }
}
