using AutoMapper;
using Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class BaseService
    {
        protected IMapper mapper = MapperInit.Instance;
    }
}
