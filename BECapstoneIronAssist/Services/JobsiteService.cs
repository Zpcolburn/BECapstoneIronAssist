using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Repositories;

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

        public async Task<Jobsite> AddJobsiteAsync(Jobsite newJobsite)
        {
            return await _jobsiteRepository.AddJobsiteAsync(newJobsite);
        }

        public async Task<Jobsite> UpdateSingleJobsiteAsync(int id, Jobsite updateJobsite)
        {
            return await _jobsiteRepository.UpdateSingleJobsiteAsync(id, updateJobsite);
        }
        public async Task<Jobsite> DeleteSingleJobsiteAsync(int id)
        {
            return await _jobsiteRepository.DeleteSingleJobsiteAsync(id);
        }
    }
}
