using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Interfaces
{
    public interface IUserService
    {
        Task <User?> CheckUserAsync(string uid);
        Task <List<User>> GetAllUsersAsync();
        Task <User> GetSingleUserAsync(int id);
        Task <User> AddUserAsync(User newUser);
        Task<User> UpdateSingleUserAsync(int id, User newUser);
    }
}
