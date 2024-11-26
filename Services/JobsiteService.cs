using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Services
{
    public class JobsiteService : IJobsiteService
    {
        private readonly IJobsiteRepository _jobsiteRepository;

        public JobsiteService(IJobsiteRepository jobsiteRepository)
        {
            _jobsiteRepository = jobsiteRepository;
        }

        public async Task<List<Jobsite>> GetAllJobsitesAsync()
        {
            return await _jobsiteRepository.GetAllJobsitesAsync();
        }
        public async Task<Jobsite> GetSingleJobsiteAsync(int id)
        {
            return await _jobsiteRepository.GetSingleJobsiteAsync(id);
        }

        public Task<Jobsite> AddJobsiteAsync(Jobsite newJobsite)
        {
            throw new NotImplementedException();
        }

        public Task<Jobsite> DeleteSingleJobsiteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Jobsite> UpdateSingleJobsiteAsync(int id, Jobsite newJobsite)
        {
            throw new NotImplementedException();
        }
    }
}
