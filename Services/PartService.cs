using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Repositories;

namespace BECapstoneIronAssist.Services
{
    public class PartService : IPartService
    {
        private readonly IPartRepository _partRepository;

        public PartService(IPartRepository partRepository)
        {
            _partRepository = partRepository;
        }
        public async Task<List<Part>> GetAllPartAsync()
        {
            return await _partRepository.GetAllPartAsync();
        }
        public async Task<Part> GetSinglePartAsync(int id)
        {
            return await _partRepository.GetSinglePartAsync(id);
        }
        public async Task<Part> AddPartAsync(Part newPart)
        {
            return await _partRepository.AddPartAsync(newPart);
        }
        public async Task<Part> UpdateSinglePartAsync(int id, Part updatePart)
        {
            return await _partRepository.UpdateSinglePartAsync(id, updatePart);
        }
        public Task<Part> DeleteSinglePartAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
