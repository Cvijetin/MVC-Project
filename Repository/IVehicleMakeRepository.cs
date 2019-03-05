using DAL;
using Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DTO;

namespace Repository
{
    public interface IVehicleMakeRepository
    {
        Task<IEnumerable<IVehicleMakeDTO>> GetPagedListAsync(IArrange arrange);
        Task<int> DeleteAsync(IVehicleMakeDTO vehicleMakeDTO);
        Task<IVehicleMakeDTO> GetByIdAsync(int id);
        Task<int> InsertAsync(IVehicleMakeDTO vehicleMakeDTO);
        Task<int> UpdateAsync(IVehicleMakeDTO vehicleMakeDTO);
        Task<IEnumerable<IVehicleMakeDTO>> GetAllAsync();
    }
}
