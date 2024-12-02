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
        public async Task<Part> UpdateSinglePartAsync(int id, Part updatePart)
        {
            var partToUpdate = await dbContext.Parts.FirstOrDefaultAsync(p => p.Id == id);
            if (partToUpdate == null)
            {
                return null;
            }
            partToUpdate.Name = updatePart.Name;
            partToUpdate.Description = updatePart.Description;
            partToUpdate.PartNumber = updatePart.PartNumber;
            partToUpdate.Description = updatePart.Description;
            partToUpdate.Quantity = updatePart.Quantity;
            partToUpdate.Price = updatePart.Price;
            partToUpdate.Location = updatePart.Location;

            await dbContext.SaveChangesAsync();
            return partToUpdate;
        }
        public Task<Part> DeleteSinglePartAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
