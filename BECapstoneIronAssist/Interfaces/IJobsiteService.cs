using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Interfaces
{
    public interface IJobsiteService
    {
        Task <List<Jobsite>> GetAllJobsitesAsync();
        Task <Jobsite> GetSingleJobsiteAsync(int id);
        Task <Jobsite> AddJobsiteAsync(Jobsite newJobsite);
        Task <Jobsite> UpdateSingleJobsiteAsync(int id, Jobsite newJobsite);
        Task <Jobsite> DeleteSingleJobsiteAsync(int id);
    }
}
