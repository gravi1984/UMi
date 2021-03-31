using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Umi.API.Helper
{
    public class PaginationList<T> : List<T>
    {
        
        public int TotalPages { get; private set; }
        public int TotalCount { get; private set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }

        public PaginationList(int currentPage, int pageSize, List<T> items, int totalCount)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            AddRange(items);
            TotalCount = totalCount;
            TotalPages = (int) Math.Ceiling(totalCount / (double) pageSize);
        }

        public static async Task<PaginationList<T>> CreateAsync(int currentPage, int pageSize, IQueryable<T> result)
        {
            // db opt: better async
            var totalCount = await result.CountAsync();
            
            // paginationL: Skip + Take
            var skip = (currentPage - 1) * pageSize;
            result = result.Skip(skip);
            result = result.Take(pageSize);
            

            // if keyword is empty, return all list is fine.
           var items =  await result.ToListAsync();
            
            return new PaginationList<T>(currentPage, pageSize, items, totalCount);
            
        }
        
    }
}