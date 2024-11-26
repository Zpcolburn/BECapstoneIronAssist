using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Repositories;

namespace BECapstoneIronAssist.Services
{
    public class EquipmentService :IEquipmentService
    {
        private readonly IEquipmentRepository _equipmentRepository;

        public async Task<List<Equipment>> GetAllEquipmentAsync()
        {
            return await _equipmentRepository.GetAllEquipmentAsync();
        }

        public async Task<Equipment> GetSingleEquipmentAsync(int id)
        {
            return await _equipmentRepository.GetSingleEquipmentAsync(id);
        }

        public EquipmentService(IEquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
        }

        public Task<Equipment> AddEquipmentAsync(Equipment newEquipment)
        {
            throw new NotImplementedException();
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
