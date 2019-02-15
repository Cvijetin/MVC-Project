using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class VehicleMakeData : BaseData
    {
        public List<VehicleMake> GetVehicles()
        {
            var vehicleMakes = db.VehicleMakes.ToList();
            return vehicleMakes;
        }

        public VehicleMake GetVehicleMakeItemById(int id)
        {
            return db.VehicleMakes.FirstOrDefault(i => i.Id == id);
        }

        public void SaveVehicleMakeChanges()
        {
            db.SaveChanges();
        }

        public void AddNewVehicleMake(VehicleMake newVehicleMakeItem)
        {
            db.VehicleMakes.Add(newVehicleMakeItem);
            db.SaveChanges();
        }

        public void DeleteVehicleMake(VehicleMake vehicleMake)
        {
            db.VehicleMakes.Remove(vehicleMake);
            db.SaveChanges();
        }
    }
}
