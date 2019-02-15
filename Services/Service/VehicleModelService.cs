using Model.DTO;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class VehicleModelService : BaseService
    {
        private VehicleModelData vehicleModelData = new VehicleModelData();

        public List<VehicleModelDTO> GetVehicleModelInfo()
        {
            
            return mapper.Map<List<VehicleModelDTO>>(vehicleModelData.GetVehicleModels());
        }
    }
}
