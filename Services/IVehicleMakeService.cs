using DAL;
using Model.DTO;
using Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IVehicleMakeService
    {
        Task<List<IVehicleMakeDTO>> GetAllAsync();
        Task<IVehicleMakeDTO> GetByIdAsync(int id);
        Task<int> InsertAsync(IVehicleMakeDTO vehicleMakePoco);
        Task<int> Update(IVehicleMakeDTO vehicleMakePoco);
        Task<int> DeleteAsync(int id);
        Task<IEnumerable<IVehicleMakeDTO>> GetPagedListAsync(IArrange arrange);
    }
}
