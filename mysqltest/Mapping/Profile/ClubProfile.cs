using AutoMapper;
using mysqltest.Mapping.DTO;
using mysqltest.Models;

namespace mysqltest.Mapping
{
    public class ClubProfile : Profile
    {
        public ClubProfile()
        {
            CreateMap<Club, ClubDTO>()
                .ForMember(dest => dest.StudentCount,
                           opt => opt.MapFrom(src => src.Students.Count));

            CreateMap<Club, ClubListingDTO>();
        }
    }
}