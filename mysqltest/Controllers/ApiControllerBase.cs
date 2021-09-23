using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using mysqltest.Models;
using mysqltest.Paging;
using System.Collections.Generic;
using System.Linq;

namespace mysqltest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiControllerBase : ControllerBase
    {
        protected readonly IMapper _mapper;
        protected readonly ClubsContext _context;

        public ApiControllerBase(ClubsContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="TDto"></typeparam>
        /// <param name="query"></param>
        /// <param name="paginationParameters"></param>
        /// <returns></returns>
        public List<TDto> Paginate<TDto>(IQueryable query, PaginationParameters paginationParameters)
        {
            return query.ProjectTo<TDto>(_mapper.ConfigurationProvider)
                        .Skip((paginationParameters.PageNumber - 1) * paginationParameters.PageSize) //Skippin adding process PageNumber and PageSize
                        .Take(paginationParameters.PageSize) //Using PageSize
                        .ToList(); // Execute the query (get data)
        }
    }
}