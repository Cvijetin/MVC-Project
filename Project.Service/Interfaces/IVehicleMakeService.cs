using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Interfaces
{
    public interface IVehicleMakeService
    {
        
        Task<IVehicleMake> GetByIdAsync(int id);
        

        Task<IEnumerable<IVehicleMake>> GetPagedListAsync(IArrange arrange);
        Task<IEnumerable<IVehicleMake>> GetAllAsync();
    }
}
