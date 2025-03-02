using HiringManagementSystemProj.DbModels;

namespace HiringManagementSystemProj.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<User> CreateUserAsync(User user);
        Task<User> GetUserByEmailAsync(string email);
    }

}
