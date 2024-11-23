using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Interfaces
{
    public interface IJobsiteRepository
    {
        Task <List<Jobsite>> GetAllJobsitesAsync();
        Task <Jobsite> AddJobsiteAsync(Jobsite newJobsite);
        Task <Jobsite> UpdateSingleJobsiteAsync(int id, Jobsite newJobsite);
        Task<Jobsite> DeleteSingleJobsiteAsync(int id);
    }
}
