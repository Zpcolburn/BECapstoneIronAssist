using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Services;
using Moq;
using Xunit;

namespace IronAssist.Test.UnitTests
{
    public class EquipmentTest
    {
        private readonly EquipmentService _equipmentService;

        private readonly Mock<IEquipmentRepository> _mockEquipmentRepository;

        public EquipmentTest()
        {
            _mockEquipmentRepository = new Mock<IEquipmentRepository>();
            _equipmentService = new EquipmentService(_mockEquipmentRepository.Object);
        }

        [Fact]
        public async Task GetAllEquipmentAsync_ShouldReturnListOfEquipment()
        {
            // Arrange
            var mockEquipmentList = new List<Equipment>
            {
                new Equipment { Id = 1, Make = "Caterpillar", Model = "D6T", Type = "Bulldozer" },
                new Equipment { Id = 2, Make = "Komatsu", Model = "PC200", Type = "Excavator" }
            };
            _mockEquipmentRepository.Setup(repo => repo.GetAllEquipmentAsync())
                                     .ReturnsAsync(mockEquipmentList);

            // Act
            var result = await _equipmentService.GetAllEquipmentAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal("Caterpillar", result[0].Make);
            Assert.Equal("Komatsu", result[1].Make);
        }

        [Fact]
        public async Task GetSingleEquipmentAsync_ShouldReturnEquipment_WhenIdIsValid()
        {
            // Arrange
            var mockEquipment = new Equipment { Id = 1, Make = "Caterpillar", Model = "D6T", Type = "Bulldozer" };
            _mockEquipmentRepository.Setup(repo => repo.GetSingleEquipmentAsync(1))
                                     .ReturnsAsync(mockEquipment);

            // Act
            var result = await _equipmentService.GetSingleEquipmentAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Caterpillar", result.Make);
            Assert.Equal("D6T", result.Model);
        }

        [Fact]
        public async Task GetSingleEquipmentAsync_ShouldReturnNull_WhenIdIsInvalid()
        {
            // Arrange
            _mockEquipmentRepository.Setup(repo => repo.GetSingleEquipmentAsync(It.IsAny<int>()))
                                     .ReturnsAsync((Equipment)null);

            // Act
            var result = await _equipmentService.GetSingleEquipmentAsync(99);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task AddEquipmentAsync_ShouldReturnAddedEquipment()
        {
            // Arrange
            var newEquipment = new Equipment { Id = 3, Make = "John Deere", Model = "850L", Type = "Dozer" };
            _mockEquipmentRepository.Setup(repo => repo.AddEquipmentAsync(newEquipment))
                                     .ReturnsAsync(newEquipment);

            // Act
            var result = await _equipmentService.AddEquipmentAsync(newEquipment);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("John Deere", result.Make);
        }

        [Fact]
        public async Task UpdateSingleEquipmentAsync_ShouldReturnUpdatedEquipment()
        {
            // Arrange
            var existingEquipment = new Equipment { Id = 1, Make = "Caterpillar", Model = "D6T", Type = "Bulldozer" };
            var updatedEquipment = new Equipment { Id = 1, Make = "Caterpillar", Model = "D6N", Type = "Bulldozer" };

            _mockEquipmentRepository.Setup(repo => repo.UpdateSingleEquipmentAsync(1, updatedEquipment))
                                     .ReturnsAsync(updatedEquipment);

            // Act
            var result = await _equipmentService.UpdateSingleEquipmentAsync(1, updatedEquipment);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("D6N", result.Model);
        }

        [Fact]
        public async Task DeleteSingleEquipmentAsync_ShouldReturnDeletedEquipment()
        {
            // Arrange
            var mockEquipment = new Equipment { Id = 1, Make = "Caterpillar", Model = "D6T", Type = "Bulldozer" };
            _mockEquipmentRepository.Setup(repo => repo.DeleteSingleEquipmentAsync(1))
                                     .ReturnsAsync(mockEquipment);

            // Act
            var result = await _equipmentService.DeleteSingleEquipmentAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public async Task DeleteSingleEquipmentAsync_ShouldReturnNull_WhenIdIsInvalid()
        {
            // Arrange
            _mockEquipmentRepository.Setup(repo => repo.DeleteSingleEquipmentAsync(It.IsAny<int>()))
                                     .ReturnsAsync((Equipment)null);

            // Act
            var result = await _equipmentService.DeleteSingleEquipmentAsync(99);

            // Assert
            Assert.Null(result);
        }
    }
}
