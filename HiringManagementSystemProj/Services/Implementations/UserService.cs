using HiringManagementSystemProj.DbModels;
using HiringManagementSystemProj.DTOs;
using HiringManagementSystemProj.Repository.Interfaces;
using HiringManagementSystemProj.Services.Interfaces;
using Org.BouncyCastle.Crypto.Generators;

namespace HiringManagementSystemProj.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> RegisterUserAsync(UserDto userDto)
        {
            // Check if user already exists
            var existingUser = await _userRepository.GetUserByEmailAsync(userDto.Email);
            if (existingUser != null)
            {
                throw new Exception("User with this email already exists.");
            }

            // Map DTO to User entity
            var user = new User
            {
                Name = userDto.Name,
                Email = userDto.Email,
               // Password = BCrypt.Net.BCrypt.HashPassword(userDto.Password), // Secure password
                Password = userDto.Password, // Secure password
                Role = userDto.Role,
                CreatedAt = DateTime.UtcNow
            };

            return await _userRepository.CreateUserAsync(user);
        }
    }

}
