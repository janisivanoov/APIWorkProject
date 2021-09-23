using System;

namespace mysqltest.Paging
{
    public class QueryStudentParameters : PaginationParameters
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}