using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Interfaces
{
    public interface IPartService
    {
        Task<List<Part>> GetAllPartAsync();
        Task<Part> GetSinglePartAsync(int id);
        Task<Part> AddPartAsync(Part newPart);
        Task<Part> UpdateSinglePartAsync(int id, Part updatePart);
        Task<Part> DeleteSinglePartAsync(int id);
    }
}
