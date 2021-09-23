using System;
using System.ComponentModel.DataAnnotations;

namespace mysqltest.Paging
{
    public class PaginationParameters
    {
        private const int maxPageSize = 50;

        public int PageNumber { get; set; } = 1;

        [Range(1, maxPageSize)]
        public int PageSize { get; set; }
    }
}