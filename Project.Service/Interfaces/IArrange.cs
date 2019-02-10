﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Interfaces
{
  public interface IArrange
    {
        int? Page { get; set; }
        int PageSize { get; set; }
        string SearchString { get; set; }
        string SortOrder { get; set; }
    }
}
