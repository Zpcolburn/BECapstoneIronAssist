using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Repositories;

namespace BECapstoneIronAssist.Services
{
    public class EquipmentService :IEquipmentService
    {
        private readonly IEquipmentRepository _equipmentRepository;
        public EquipmentService(IEquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
        }
        public async Task<List<Equipment>> GetAllEquipmentAsync()
        {
            return await _equipmentRepository.GetAllEquipmentAsync();
        }

        public async Task<Equipment> GetSingleEquipmentAsync(int id)
        {
            return await _equipmentRepository.GetSingleEquipmentAsync(id);
        }

        public async Task<Equipment> AddEquipmentAsync(Equipment newEquipment)
        {
            return await _equipmentRepository.AddEquipmentAsync(newEquipment);
        }

        public async Task<Equipment> UpdateSingleEquipmentAsync(int id, Equipment updateEquipment)
        {
            return await _equipmentRepository.UpdateSingleEquipmentAsync(id, updateEquipment);
        }

        public Task<Equipment> DeleteSingleEquipmentAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
