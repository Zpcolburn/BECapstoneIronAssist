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

        public async Task<Report> AddReportAsync(Report newReport)
        {
            return await _reportRepository.AddReportAsync(newReport);
        }

        public async Task<Report> UpdateSingleReportAsync(int id, Report updateReport)
        {
            return await _reportRepository.UpdateSingleReportAsync(id, updateReport);
        }

        public async Task<Report> DeleteSingleReportAsync(int id)
        {
            return await _reportRepository.DeleteSingleReportAsync(id);
        }

    }
}
