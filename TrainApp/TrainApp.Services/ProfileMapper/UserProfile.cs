using AutoMapper;
using TrainApp.Dtos;
using TrainApp.Entities;

namespace TrainApp.Services.ProfileMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, UserEntity>().ReverseMap();
        }
    }
}
