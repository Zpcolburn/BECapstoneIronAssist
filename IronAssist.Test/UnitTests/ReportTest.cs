using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Services;
using Moq;
using Xunit;

namespace IronAssist.Test.UnitTests
{
    public class ReportServiceTest
    {
        private readonly Mock<IReportRepository> _mockReportRepository;
        private readonly ReportService _reportService;

        public ReportServiceTest()
        {
            _mockReportRepository = new Mock<IReportRepository>();
            _reportService = new ReportService(_mockReportRepository.Object);
        }

        [Fact]
        public async Task GetAllReportsAsync_ShouldReturnListOfReports()
        {
            // Arrange
            var reports = new List<Report>
            {
                new Report { Id = 1, ReportDate = 20231201, Description = "Report 1", IsPublic = true, Priority = "High", Status = "Open", UserId = 1 },
                new Report { Id = 2, ReportDate = 20231202, Description = "Report 2", IsPublic = false, Priority = "Medium", Status = "Closed", UserId = 2 }
            };

            _mockReportRepository.Setup(repo => repo.GetAllReportsAsync()).ReturnsAsync(reports);

            // Act
            var result = await _reportService.GetAllReportsAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal("Report 1", result[0].Description);
        }

        [Fact]
        public async Task GetSingleReportAsync_ShouldReturnReportById()
        {
            // Arrange
            var report = new Report { Id = 1, ReportDate = 20231201, Description = "Report 1", IsPublic = true, Priority = "High", Status = "Open", UserId = 1 };

            _mockReportRepository.Setup(repo => repo.GetSingleReportAsync(report.Id)).ReturnsAsync(report);

            // Act
            var result = await _reportService.GetSingleReportAsync(report.Id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(report.Id, result.Id);
            Assert.Equal("Report 1", result.Description);
        }

        [Fact]
        public async Task AddReportAsync_ShouldAddAndReturnReport()
        {
            // Arrange
            var newReport = new Report { Id = 1, ReportDate = 20231203, Description = "New Report", IsPublic = true, Priority = "Low", Status = "Pending", UserId = 1 };

            _mockReportRepository.Setup(repo => repo.AddReportAsync(newReport)).ReturnsAsync(newReport);

            // Act
            var result = await _reportService.AddReportAsync(newReport);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(newReport.Id, result.Id);
            Assert.Equal("New Report", result.Description);
        }

        [Fact]
        public async Task UpdateSingleReportAsync_ShouldUpdateAndReturnUpdatedReport()
        {
            // Arrange
            var existingReport = new Report { Id = 1, ReportDate = 20231203, Description = "Old Report", IsPublic = false, Priority = "Low", Status = "Pending", UserId = 1 };
            var updatedReport = new Report { Id = 1, ReportDate = 20231203, Description = "Updated Report", IsPublic = true, Priority = "High", Status = "Resolved", UserId = 1 };

            _mockReportRepository.Setup(repo => repo.UpdateSingleReportAsync(existingReport.Id, updatedReport)).ReturnsAsync(updatedReport);

            // Act
            var result = await _reportService.UpdateSingleReportAsync(existingReport.Id, updatedReport);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Updated Report", result.Description);
            Assert.True(result.IsPublic);
        }

        [Fact]
        public async Task DeleteSingleReportAsync_ShouldDeleteAndReturnReport()
        {
            // Arrange
            var report = new Report { Id = 1, ReportDate = 20231204, Description = "Report to Delete", IsPublic = false, Priority = "Low", Status = "Closed", UserId = 1 };

            _mockReportRepository.Setup(repo => repo.DeleteSingleReportAsync(report.Id)).ReturnsAsync(report);

            // Act
            var result = await _reportService.DeleteSingleReportAsync(report.Id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(report.Id, result.Id);
            Assert.Equal("Report to Delete", result.Description);
        }
    }
}
