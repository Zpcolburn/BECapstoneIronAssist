using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using Microsoft.EntityFrameworkCore;

namespace BECapstoneIronAssist.Repositories
{
    public class PartRepository : IPartRepository
    {
        private readonly BECapstoneIronAssistDbContext dbContext;

        public PartRepository(BECapstoneIronAssistDbContext context)
        {
            dbContext = context;
        }
        public async Task<List<Part>> GetAllPartAsync()
        {
            return await dbContext.Parts.ToListAsync();
        }
        public async Task<Part> GetSinglePartAsync(int id)
        {
            return await dbContext.Parts.FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<Part> AddPartAsync(Part newPart)
        {
             await dbContext.AddAsync(newPart);
             await dbContext.SaveChangesAsync();
             return newPart;
        }
        public Task<Part> UpdateSinglePartAsync(int id, Part updatePart)
        {
            throw new NotImplementedException();
        }
        public Task<Part> DeleteSinglePartAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
