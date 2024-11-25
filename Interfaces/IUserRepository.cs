using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Interfaces
{
    public interface IUserRepository
    {
        Task <User?> CheckUserAsync(string uid);
        Task <List<User>> GetAllUsersAsync();
        Task <User> AddUserAsync(User newUser);
        Task <User> GetSingleUserAsync (int id);
        Task <User> UpdateSingleUserAsync(int id, User newUser);
        Task <User> DeleteUserAsync(int id);
        Task<Task<User>> AddUserAsync();
    }
}
