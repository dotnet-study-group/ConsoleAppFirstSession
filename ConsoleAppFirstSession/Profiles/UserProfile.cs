using AutoMapper;

namespace ConsoleAppFirstSession.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        /*
        CreateMap<User, UserInput>()
            .ForMember(dest => dest.Password, opt => opt.MapFrom(u => u.Password))
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(u => u.UserName))
            .ForMember(dest => dest.RoleId, opt => opt.MapFrom(u => u.RoleId))
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(u => u.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(u => u.LastName))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(u => u.Email)).ReverseMap();
            */
    }
}