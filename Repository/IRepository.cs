using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository
    {
        IQueryable<T> Get<T>() where T : class;

        Task<T> GetByIdAsync<T>(int id) where T : class;
    }
}
