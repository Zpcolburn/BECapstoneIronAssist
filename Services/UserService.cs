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

        public async Task<User?> CheckUserAsync(string uid)
        {
            return await _userRepository.CheckUserAsync(uid);
        }
        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }

        public async Task<User?> GetSingleUserAsync(int id)
        {
            return await _userRepository.GetSingleUserAsync(id);
        }
        public async Task<User> AddUserAsync(User newUser)
        {
            return await _userRepository.AddUserAsync(newUser);
        }

        public  async Task<User> UpdateSingleUserAsync(int id, User updateUser)
        {
            return await _userRepository.UpdateSingleUserAsync(id, updateUser);
        }
    }
}
