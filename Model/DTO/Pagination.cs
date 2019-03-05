using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class PaginationModel<T> : List<T>
    {
        public int TotalCount { get; set; }
        public List<T> List { get; set; }
        public PaginationModel(List<T> list, int totalCount)
        {
            this.List = list;
            this.TotalCount = totalCount;
        }

        public PaginationModel()
        {

        }
    }
}
