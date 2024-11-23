using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Services
{
    public class JobsiteService
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
    }
}
