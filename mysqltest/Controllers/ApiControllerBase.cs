using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using mysqltest.Mapping.DTO;
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

        public List<ClubDTO> Paginate<TDto>(IQueryable query, QueryClubParameters QueryClubParameters)
        {
            List<ClubDTO> clubs;

            if (QueryClubParameters.Name == "ALL") //Check situation when we want to get all clubs using "ALL"
            {
                clubs = query.ProjectTo<ClubDTO>(_mapper.ConfigurationProvider)
                            .Skip((QueryClubParameters.PageNumber - 1) * QueryClubParameters.PageSize) //Skippin adding process PageNumber and PageSize
                            .Take(QueryClubParameters.PageSize) //Using PageSize
                            .ToList(); //Sending to List
            }
            else //Situation when we enter a name like "Math"
            {
                clubs = query.ProjectTo<ClubDTO>(_mapper.ConfigurationProvider)
                          .Where(c => c.Name == QueryClubParameters.Name)
                          .Skip((QueryClubParameters.PageNumber - 1) * QueryClubParameters.PageSize) //Skippin adding process PageNumber and PageSize
                          .Take(QueryClubParameters.PageSize) //Using PageSize
                          .ToList(); //Sending to List
            }

            return clubs;
        }

        public List<StudentDTO> Paginate<TDTO>(IQueryable<TDTO> query, QueryStudentParameters QueryStudentParameters)
        {
            List<StudentDTO> students;

            if (QueryStudentParameters.Name == "ALL") //Check situation when we want to get all clubs using "ALL"
            {
                students = query.ProjectTo<StudentDTO>(_mapper.ConfigurationProvider)
                                .Skip((QueryStudentParameters.PageNumber - 1) * QueryStudentParameters.PageSize) //Skipping adding process PageNumber and PageSize
                                .Take(QueryStudentParameters.PageSize) //Using PageSize
                                .ToList(); //Sending to List
            }
            else //Situation when we enter a name like "Ali"
            {
                students = query.ProjectTo<StudentDTO>(_mapper.ConfigurationProvider)
                             .Where(c => c.FirstName == QueryStudentParameters.Name)
                             .Skip((QueryStudentParameters.PageNumber - 1) * QueryStudentParameters.PageSize) //Skipping adding process PageNumber and PageSize
                             .Take(QueryStudentParameters.PageSize) //Using PageSize
                             .ToList(); //Sending to List}
            }
            return students;
        }
    }
}