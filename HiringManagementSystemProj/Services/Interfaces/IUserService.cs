using HiringManagementSystemProj.DbModels;
using HiringManagementSystemProj.DTOs;

namespace HiringManagementSystemProj.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> RegisterUserAsync(UserDto userDto);
    }

}
