using Project.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Implementation
{
    public class VehicleMakeService
    {
        private IVehicleMakeService _repository;

        public VehicleMakeService(IVehicleMakeService repository)
        {
            _repository = repository;
        }
        public virtual async Task<List<IVehicleMake>> GetAllAsync()
        {
            try
            {
                var vehicleMakes = await _repository.GetAllAsync();
                return vehicleMakes.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual Task<IVehicleMake> GetByIdAsync(int id)
        {
            try
            {
                var vehicleById = _repository.GetByIdAsync(id);
                return vehicleById;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
