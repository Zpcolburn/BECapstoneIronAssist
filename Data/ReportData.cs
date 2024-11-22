using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Data
{
    public class ReportData
    {
        public static List<Report> Reports = new()
        {
            new Report
            {
                Id = 1, 
                ReportDate = 2024-11-04,
                EquipmentId = 1,
                UserId = 1,
                JobsiteId = 2,
                Image = "https://test.com",
                Description = "The cutting edges on the blade need to be flipped, and the ripper teeth need to be replaced.",
                IsPublic = true, 
                Priority = "Low",
                Status = "Backlog",
                Assign = false
            },
            new Report
            {
                Id = 2,
                ReportDate = 2024-10-16,
                EquipmentId = 2,
                UserId = 1,
                JobsiteId = 2,
                Image = "https://test.com",
                Description = "Thrown right track, needs to be put back on.",
                IsPublic = true,
                Priority = "High",
                Status = "Backlog",
                Assign = false
            },
            new Report
            {
                Id = 3,
                ReportDate = 2024-07-20,
                EquipmentId = 3,
                UserId = 2,
                JobsiteId = 3,
                Image = "https://test.com",
                Description = "Front bucket cylinder shaft bent.",
                IsPublic = true,
                Priority = "High",
                Status = "Closed",
                Assign = true
            },
            new Report
            {
                Id = 4,
                ReportDate = 2024-10-25,
                EquipmentId = 4,
                UserId = 2,
                JobsiteId = 4,
                Image = "https://test.com",
                Description = "Front glass broken, looks like from a rock.",
                IsPublic = true,
                Priority = "low",
                Status = "Closed",
                Assign = true
            },
        };
    }
}
