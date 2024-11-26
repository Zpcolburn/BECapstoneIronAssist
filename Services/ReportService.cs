using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Services
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _reportRepository;

        public ReportService(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public async Task<List<Report>> GetAllReportsAsync()
        {
            return await _reportRepository.GetAllReportsAsync();
        }

        public async Task<Report> GetSingleReportAsync(int id)
        {
            return await _reportRepository.GetSingleReportAsync(id);
        }

        public Task<Report> UpdateSingleReportAsync(int id, Report newReport)
        {
            throw new NotImplementedException();
        }

        public Task<Report> AddReportAsync(Report newReport)
        {
            throw new NotImplementedException();
        }

        public Task<Report> DeleteSingleReportAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
