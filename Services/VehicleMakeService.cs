using Model.DTO;
using Repository;
using Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class VehicleMakeService : IVehicleMakeService
    {
        private IVehicleMakeRepository _repository;

        public VehicleMakeService(IVehicleMakeRepository repository)
        {
            _repository = repository;
        }

        public virtual async Task<List<IVehicleMakeDTO>> GetAllAsync()
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

        public virtual Task<IVehicleMakeDTO> GetByIdAsync(int id)
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

        public virtual async Task<int> InsertAsync(IVehicleMakeDTO vehicleMakePoco)
        {
            try
            {
                return await _repository.InsertAsync(vehicleMakePoco);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual Task<int> Update(IVehicleMakeDTO vehicleMakePoco)
        {
            try
            {
                return _repository.UpdateAsync(vehicleMakePoco);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual async Task<int> DeleteAsync(int id)
        {
            try
            {
                var vehicleById = await _repository.GetByIdAsync(id);
                return await _repository.DeleteAsync(vehicleById);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual async Task<IEnumerable<IVehicleMakeDTO>> GetPagedListAsync(IArrange arrange)
        {
            try
            {
                var pagedList = await _repository.GetPagedListAsync(arrange);

                return pagedList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
