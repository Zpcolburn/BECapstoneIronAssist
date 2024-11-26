using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Interfaces
{
    public interface IEquipmentRepository
    {
        Task <List<Equipment>> GetAllEquipmentAsync();
        Task<Equipment> GetSingleEquipmentAsync(int id);
        Task <Equipment> AddEquipmentAsync(Equipment newEquipment);
        Task <Equipment> UpdateSingleEquipmentAsync(int id, Equipment newEquipment);
        Task <Equipment> DeleteSingleEquipmentAsync(int id);
    }
}
