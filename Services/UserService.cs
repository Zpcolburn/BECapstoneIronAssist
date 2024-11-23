using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> AddUserAsync(User newUser)
        {
            throw new NotImplementedException();
        }

        public Task<User> DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }

        public Task<User> UpdateSingleUserAsync(int id, User newUser)
        {
            throw new NotImplementedException();
        }
    }
}
