using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using Microsoft.EntityFrameworkCore;

namespace BECapstoneIronAssist.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BECapstoneIronAssistDbContext dbContext;

        public UserRepository(BECapstoneIronAssistDbContext context) 
        {
            dbContext = context;
        }

        public Task<User> AddUserAsync(User newUser)
        {
            throw new NotImplementedException();
        }

        public Task<User> DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        // Get All Users
        public async Task<List<User>> GetAllUsersAsync()
        {
            return await dbContext.Users.ToListAsync();
        }

        public Task<User> UpdateSingleUserAsync(int id, User newUser)
        {
            throw new NotImplementedException();
        }
    }
}
