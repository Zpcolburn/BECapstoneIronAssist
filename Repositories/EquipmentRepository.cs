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
        public async Task<Equipment> UpdateSingleEquipmentAsync(int id, Equipment updateEquipment)
        {
            var equipmentToUpdate = await dbContext.Equipment.FirstOrDefaultAsync(e => e.Id == id);

            if (equipmentToUpdate == null)
            {
                return null;
            }
            equipmentToUpdate.Make = updateEquipment.Make;
            equipmentToUpdate.Model = updateEquipment.Model;
            equipmentToUpdate.Type = updateEquipment.Type;
            equipmentToUpdate.Image = updateEquipment.Image;
            equipmentToUpdate.Description = updateEquipment.Description;

            await dbContext.SaveChangesAsync();
            return equipmentToUpdate;
        }

        public Task<Equipment> DeleteSingleEquipmentAsync(int id)
        {
            throw new NotImplementedException();
        }

    }
}
