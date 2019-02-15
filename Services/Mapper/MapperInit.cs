using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapper
{
    public class MapperInit
    {
        private static IMapper instance;
        public static IMapper Instance { get { return instance; } }

        public static void RegisterMappings()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            instance = config.CreateMapper();

        }
    }
}
