using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Services;
using Moq;
using Xunit;

namespace IronAssist.Test.UnitTests
{
    public class JobsiteServiceTest
    {
        private readonly Mock<IJobsiteRepository> _mockJobsiteRepository;
        private readonly JobsiteService _jobsiteService;

        public JobsiteServiceTest()
        {
            _mockJobsiteRepository = new Mock<IJobsiteRepository>();
            _jobsiteService = new JobsiteService(_mockJobsiteRepository.Object);
        }

        [Fact]
        public async Task GetAllJobsitesAsync_ShouldReturnAllJobsites()
        {
            // Arrange
            var jobsites = new List<Jobsite>
            {
                new Jobsite { Id = 1, Name = "Jobsite 1", Location = "Location 1" },
                new Jobsite { Id = 2, Name = "Jobsite 2", Location = "Location 2" }
            };
            _mockJobsiteRepository.Setup(repo => repo.GetAllJobsitesAsync()).ReturnsAsync(jobsites);

            // Act
            var result = await _jobsiteService.GetAllJobsitesAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal("Jobsite 1", result[0].Name);
            Assert.Equal("Location 2", result[1].Location);
        }

        [Fact]
        public async Task GetSingleJobsiteAsync_ShouldReturnCorrectJobsite()
        {
            // Arrange
            var jobsite = new Jobsite { Id = 1, Name = "Jobsite 1", Location = "Location 1" };
            _mockJobsiteRepository.Setup(repo => repo.GetSingleJobsiteAsync(1)).ReturnsAsync(jobsite);

            // Act
            var result = await _jobsiteService.GetSingleJobsiteAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("Jobsite 1", result.Name);
        }

        [Fact]
        public async Task AddJobsiteAsync_ShouldAddAndReturnJobsite()
        {
            // Arrange
            var newJobsite = new Jobsite { Id = 1, Name = "New Jobsite", Location = "New Location" };
            _mockJobsiteRepository.Setup(repo => repo.AddJobsiteAsync(newJobsite)).ReturnsAsync(newJobsite);

            // Act
            var result = await _jobsiteService.AddJobsiteAsync(newJobsite);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("New Jobsite", result.Name);
            Assert.Equal("New Location", result.Location);
        }

        [Fact]
        public async Task UpdateSingleJobsiteAsync_ShouldUpdateAndReturnJobsite()
        {
            // Arrange
            var updatedJobsite = new Jobsite { Id = 1, Name = "Updated Jobsite", Location = "Updated Location" };
            _mockJobsiteRepository.Setup(repo => repo.UpdateSingleJobsiteAsync(1, updatedJobsite)).ReturnsAsync(updatedJobsite);

            // Act
            var result = await _jobsiteService.UpdateSingleJobsiteAsync(1, updatedJobsite);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Updated Jobsite", result.Name);
            Assert.Equal("Updated Location", result.Location);
        }

        [Fact]
        public async Task DeleteSingleJobsiteAsync_ShouldDeleteAndReturnJobsite()
        {
            // Arrange
            var jobsiteToDelete = new Jobsite { Id = 1, Name = "Jobsite to Delete", Location = "Delete Location" };
            _mockJobsiteRepository.Setup(repo => repo.DeleteSingleJobsiteAsync(1)).ReturnsAsync(jobsiteToDelete);

            // Act
            var result = await _jobsiteService.DeleteSingleJobsiteAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("Jobsite to Delete", result.Name);
        }
    }
}
