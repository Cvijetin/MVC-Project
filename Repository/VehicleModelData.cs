using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
  public class VehicleModelData : BaseData
    {
        public List<VehicleModel> GetVehicleModels()
        {
            var vehicleModel = db.VehicleModels.ToList();
            return vehicleModel;
        }

        public VehicleModel GetVehicleModelById(int id)
        {
            return db.VehicleModels.FirstOrDefault(i => i.Id == id);
        }

        public void SaveVehicleMakeChanges()
        {
            db.SaveChanges();
        }

        public void AddNewVehicleModel(VehicleModel newVehicleModelItem)
        {
            db.VehicleModels.Add(newVehicleModelItem);
            db.SaveChanges();
        }

        public void DeleteVehicleMake(VehicleModel deleteVehicleModel)
        {
            db.VehicleModels.Remove(deleteVehicleModel);
            db.SaveChanges();
        }
    }
}
