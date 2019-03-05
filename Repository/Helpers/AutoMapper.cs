using AutoMapper;
using DAL;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Helpers
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<VehicleModel, VehicleModelDTO>().ReverseMap();
                cfg.CreateMap<VehicleMake, VehicleMakeDTO>().ReverseMap();

            });
        }
    }
}
