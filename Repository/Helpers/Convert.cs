using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Repository.Helpers
{
    public static class Convert
    {
        public static IPagedList<TDestination> ToMappedPagedList<TSource, TDestination>(this IPagedList<TSource> pagedList)
        {
            var paged = pagedList;
            IEnumerable<TDestination> sourceList = Mapper.Map<IEnumerable<TDestination>>(pagedList);
            IPagedList<TDestination> pagedListDto = new StaticPagedList<TDestination>(sourceList, pagedList.GetMetaData());
            return pagedListDto;
        }
    }
}
