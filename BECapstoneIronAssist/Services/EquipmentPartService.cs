using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Repositories;

namespace BECapstoneIronAssist.Services
{
    public class EquipmentPartService : IEquipmentPartService
    {
        private readonly IEquipmentPartRepository _equipmentPartRepository;
        public EquipmentPartService(IEquipmentPartRepository equipmentPartRepository)
        {
            _equipmentPartRepository = equipmentPartRepository;
        }

        public async Task<EquipmentPart> AddEquipmentPartAsync(int equipmentId, int partId)
        {
            return await _equipmentPartRepository.AddEquipmentPartAsync(equipmentId, partId);
        }
        public async Task<EquipmentPart> UpdateEquipmentPartAsync(int equipmentId, int partId, EquipmentPart updatedEquipmentPart)
        {
            return await _equipmentPartRepository.UpdateEquipmentPartAsync(equipmentId, partId, updatedEquipmentPart);
        }
        public async Task<EquipmentPart> DeleteEquipmentPartAsync(int equipmentId, int partId)
        {
            return await _equipmentPartRepository.DeleteEquipmentPartAsync(equipmentId, partId);
        }
    }
}
