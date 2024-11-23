using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Interfaces
{
    public interface IReportService
    {
        Task <List<Report>> GetAllReportsAsync();
        Task <Report> AddReportAsync(Report newReport);
        Task <Report> UpdateSingleReportAsync(int id, Report newReport);
        Task <Report> DeleteSingleReportAsync(int id);
    }
}
