﻿using BECapstoneIronAssist.Interfaces;
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
        public async Task<Report> AddReportAsync(Report newReport)
        {
            await dbContext.AddAsync(newReport);
            await dbContext.SaveChangesAsync();
            return newReport;
        }

        // Update Single Report
        public async Task<Report> UpdateSingleReportAsync(int id, Report updateReport)
        {
            var reportToUpdate = await dbContext.Reports.FirstOrDefaultAsync(r =>r.Id == id);
            if (reportToUpdate == null)
            {
                return null;
            }
            reportToUpdate.EquipmentId = updateReport.EquipmentId;
            reportToUpdate.JobsiteId = updateReport.JobsiteId;
            reportToUpdate.Image = updateReport.Image;
            reportToUpdate.Description = updateReport.Description;
            reportToUpdate.IsPublic = updateReport.IsPublic;

            await dbContext.SaveChangesAsync();
            return reportToUpdate;
        }

        // Delete Single Report
        public async Task<Report> DeleteSingleReportAsync(int id)
        {
            var reportToDelete = await dbContext.Reports.FirstOrDefaultAsync(r =>r.Id == id);
            if(reportToDelete == null)
            {
                return null;
            }
            dbContext.Reports.Remove(reportToDelete);
            await dbContext.SaveChangesAsync();
            return reportToDelete;
        }
    }
}
