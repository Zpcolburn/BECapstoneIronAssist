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

        public async Task<Jobsite> UpdateSingleJobsiteAsync(int id, Jobsite updateJobsite)
        {
            var jobsiteToUpdate = await dbContext.Jobsites.FirstOrDefaultAsync(j => j.Id == id);

            if (jobsiteToUpdate == null)
            {
                return null;
            }
            jobsiteToUpdate.Name = updateJobsite.Name;
            jobsiteToUpdate.Location = updateJobsite.Location;
            jobsiteToUpdate.Image = updateJobsite.Image;

            await dbContext.SaveChangesAsync();
            return jobsiteToUpdate;
        }

        public async Task<Jobsite> DeleteSingleJobsiteAsync(int id)
        {
            var jobsiteToDelete = await dbContext.Jobsites.FirstOrDefaultAsync(j => j.Id == id);

            if (jobsiteToDelete == null)
            {
                return null;
            }
            dbContext.Jobsites.Remove(jobsiteToDelete);
            await dbContext.SaveChangesAsync();
            return jobsiteToDelete;
        }
    }
}
