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
        // Check User
        public async Task<User?> CheckUserAsync(string uid)
        {
            return await dbContext.Users.FirstOrDefaultAsync(u => u.Uid == uid);
        }

        // Get All Users
        public async Task<List<User>> GetAllUsersAsync()
        {
            return await dbContext.Users.ToListAsync();
        }

        // Get single User
        public async Task<User?> GetSingleUserAsync(int id)
        {
            return await dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        // Post(add) new User
        public async Task<User> AddUserAsync(User newUser) 
        {
           await dbContext.Users.AddAsync(newUser);
            await dbContext.SaveChangesAsync();
           return newUser;
        }

        // Put(Edit) User
        public async Task<User> UpdateSingleUserAsync(int id, User updateUser)
        {
            var userToUpdate = await dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
            
            if (userToUpdate == null) 
            {
                return null;
            }
            userToUpdate.FirstName = updateUser.FirstName;
            userToUpdate.LastName = updateUser.LastName;
            userToUpdate.Email = updateUser.Email;
            userToUpdate.Role = updateUser.Role;

            await dbContext.SaveChangesAsync();
            return userToUpdate;
        }
    }
}
