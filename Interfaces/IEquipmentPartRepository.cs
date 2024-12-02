using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Interfaces
{
    public interface IEquipmentPartRepository
    {
        Task<EquipmentPart> AddEquipmentPartAsync(int equipmentId, int partId);
        Task<EquipmentPart> UpdateEquipmentPartAsync(int equipmentId, int partId, EquipmentPart updatedEquipmentPart);
        Task<EquipmentPart> DeleteEquipmentPartAsync(int equipmentId, int partId);
    }
}
