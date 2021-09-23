using AutoMapper;
using mysqltest.Mapping.DTO;
using mysqltest.Models;

namespace mysqltest.Mapping
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentDTO>();
        }
    }
}