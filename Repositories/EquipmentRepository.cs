using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using Microsoft.EntityFrameworkCore;

namespace BECapstoneIronAssist.Repositories
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly BECapstoneIronAssistDbContext dbContext;

        public EquipmentRepository(BECapstoneIronAssistDbContext context)
        {
            dbContext = context;
        }

        // Get All Equipment
        public async Task<List<Equipment>> GetAllEquipmentAsync()
        {
            return await dbContext.Equipment.ToListAsync();
        }

        // Get Single Equipment
        public async Task<Equipment> GetSingleEquipmentAsync(int id)
        {
            return await dbContext.Equipment.FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<Equipment> AddEquipmentAsync(Equipment newEquipment)
        {
            await dbContext.Equipment.AddAsync(newEquipment);
            await dbContext.SaveChangesAsync();
            return newEquipment;
        }
        public Task<Equipment> UpdateSingleEquipmentAsync(int id, Equipment newEquipment)
        {
            throw new NotImplementedException();
        }

        public Task<Equipment> DeleteSingleEquipmentAsync(int id)
        {
            throw new NotImplementedException();
        }

    }
}
