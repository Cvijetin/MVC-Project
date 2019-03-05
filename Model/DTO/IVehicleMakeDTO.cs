using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public interface IVehicleMakeDTO
    {
        int Id { get; set; }
        string Name { get; set; }
        string Abrv { get; set; }
    }
}
