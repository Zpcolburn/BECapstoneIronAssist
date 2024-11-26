using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using Microsoft.EntityFrameworkCore;

namespace BECapstoneIronAssist.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly BECapstoneIronAssistDbContext dbContext;

        public ReportRepository(BECapstoneIronAssistDbContext context)
        {
            dbContext = context;
        }

        // Get All Reports
        public async Task<List<Report>> GetAllReportsAsync()
        {
            return await dbContext.Reports.ToListAsync();
        }

        // Get Single Report
        public async Task<Report> GetSingleReportAsync(int id)
        {
            return await dbContext.Reports.FirstOrDefaultAsync(r => r.Id == id);
        }

        // Add New Report
        public Task<Report> AddReportAsync(Report newReport)
        {
            throw new NotImplementedException();
        }

        // Update Single Report
        public Task<Report> UpdateSingleReportAsync(int id, Report newReport)
        {
            throw new NotImplementedException();
        }

        // Delete Single Report
        public Task<Report> DeleteSingleReportAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
