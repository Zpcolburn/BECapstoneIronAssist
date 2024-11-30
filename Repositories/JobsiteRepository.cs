using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using Microsoft.EntityFrameworkCore;

namespace BECapstoneIronAssist.Repositories
{
    public class JobsiteRepository : IJobsiteRepository
    {
        private readonly BECapstoneIronAssistDbContext dbContext;

        public JobsiteRepository(BECapstoneIronAssistDbContext context)
        {
            dbContext = context;
        }

        public async Task<List<Jobsite>> GetAllJobsitesAsync()
        {
            return await dbContext.Jobsites.ToListAsync();
        }

        public async Task<Jobsite> GetSingleJobsiteAsync(int id)
        {
            return await dbContext.Jobsites.FirstOrDefaultAsync(j => j.Id == id);
        }

        public async Task<Jobsite> AddJobsiteAsync(Jobsite newJobsite)
        {
            await dbContext.Jobsites.AddAsync(newJobsite);
            await dbContext.SaveChangesAsync();
            return newJobsite;
        }

        public Task<Jobsite> UpdateSingleJobsiteAsync(int id, Jobsite newJobsite)
        {
            throw new NotImplementedException();
        }

        public Task<Jobsite> DeleteSingleJobsiteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
