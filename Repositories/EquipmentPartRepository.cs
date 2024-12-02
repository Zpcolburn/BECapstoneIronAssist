using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using Microsoft.EntityFrameworkCore;

namespace BECapstoneIronAssist.Repositories
{
    public class EquipmentPartRepository : IEquipmentPartRepository
    {
        private readonly BECapstoneIronAssistDbContext dbContext;

        public EquipmentPartRepository(BECapstoneIronAssistDbContext context)
        {
            dbContext = context;
        }

        public async Task<EquipmentPart> AddEquipmentPartAsync(int equipmentId, int partId)
        {
            var newEquipmentPart = new EquipmentPart
            {
                EquipmentId = equipmentId,
                PartId = partId
            };

            await dbContext.EquipmentParts.AddAsync(newEquipmentPart);
            await dbContext.SaveChangesAsync();
            return newEquipmentPart;
        }

        public async Task<EquipmentPart> UpdateEquipmentPartAsync(int equipmentId, int partId, EquipmentPart updatedEquipmentPart)
        {
            var updateEquipmentPart = await dbContext.EquipmentParts
                .FirstOrDefaultAsync(ep => ep.EquipmentId == equipmentId && ep.PartId == partId);

            if (updateEquipmentPart == null)
            {
                return null;
            }
            updateEquipmentPart.MaintenanceDate = updatedEquipmentPart.MaintenanceDate;
            updateEquipmentPart.QuantityUsed = updatedEquipmentPart.QuantityUsed;

            dbContext.EquipmentParts.Update(updateEquipmentPart);
            await dbContext.SaveChangesAsync();
            return updateEquipmentPart;
        }

        public async Task<EquipmentPart> DeleteEquipmentPartAsync(int equipmentId, int partId)
        {
            var deleteEquipmentPart = await dbContext.EquipmentParts
                .FirstOrDefaultAsync(ep => ep.EquipmentId == equipmentId && ep.PartId == partId);

            if (deleteEquipmentPart != null)
            {
                dbContext.EquipmentParts.Remove(deleteEquipmentPart);
                await dbContext.SaveChangesAsync();
            }

            return deleteEquipmentPart;
        }
    }
}
