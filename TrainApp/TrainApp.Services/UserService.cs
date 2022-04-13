using AutoMapper;
using TrainApp.Dtos;
using TrainApp.Entities;
using TrainApp.Persistence;

namespace TrainApp.Services
{
    public class UserService
    {
        private IRepositoryGeneric<UserEntity> _userRepository;
        private IMapper _mapper;

        public UserService(IRepositoryGeneric<UserEntity> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDto>> Get()
        {
            try
            {
                var userEntity = _userRepository.GetAll();
                var dto = _mapper.Map<IEnumerable<UserDto>>(userEntity);
                return dto;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}