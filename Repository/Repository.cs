using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository : IRepository
    {
        protected IMyDbContext DbContext { get; set; }
        public Repository(IMyDbContext context)
        {
            DbContext = context;
        }

        public IQueryable<T> Get<T>() where T : class
        {
            return DbContext.Set<T>();
        }

        public Task<T> GetByIdAsync<T>(int id) where T : class
        {
            return DbContext.Set<T>().FindAsync(id);
        }
    }
}
