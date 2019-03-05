using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.DTO
{
    public class VehicleModelDTO : IVehicleModelDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "*")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*")]
        public string Abrv { get; set; }
        public int MakeId { get; set; }

        public virtual VehicleMakeDTO Make
        {
            get; set;
        }
    }
}
