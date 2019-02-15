using DAL;
using Model.DTO;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
  public class VehicleMakeService : BaseService
    {
        private VehicleMakeData vehicleMakeData = new VehicleMakeData();

        public List<VehicleMakeDTO> GetVehicleMakeInfo()
        {
            return mapper.Map<List<VehicleMakeDTO>>(vehicleMakeData.GetVehicles()); 
        }

        public void CreateNewVehicleMake(VehicleMakeDTO createVehicleMakeData)
        {
            var newVehicleMake = mapper.Map<VehicleMakeDTO, VehicleMake>(createVehicleMakeData);
            vehicleMakeData.AddNewVehicleMake(newVehicleMake);
        }
    }
}
