using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BaseData
    {
        protected MyDbContext db;
        public BaseData()
        {
            db = new MyDbContext();
            db.Configuration.LazyLoadingEnabled = true;
            db.Configuration.ProxyCreationEnabled = true;
        }
    }
}
