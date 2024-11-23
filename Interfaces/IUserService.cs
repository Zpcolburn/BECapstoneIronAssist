using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Interfaces
{
    public interface IUserService
    {
        Task <List<User>> GetAllUsersAsync();
        Task <User> AddUserAsync(User newUser);
        Task <User> UpdateSingleUserAsync(int id, User newUser);
        Task <User> DeleteUserAsync(int id);
    }
}
