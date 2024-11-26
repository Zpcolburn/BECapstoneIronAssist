using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Services;
using Microsoft.AspNetCore.Mvc;

namespace BECapstoneIronAssist.Endpoints
{
    public class ReportEndpoints
    {
        public static void Map(WebApplication app)
        {
            // Get All Reports
            app.MapGet("/reports", async (IReportService reportService) =>
            {
                return await reportService.GetAllReportsAsync();
            });

            // Get Single Report
            app.MapGet("/report/{id}", async (IReportService reportService, int id) =>
            {
                var report = await reportService.GetSingleReportAsync(id);
                if (report == null)
                {
                    return Results.NotFound("Report not found");
                }
                return Results.Ok(report);
            });
        }
    }
}
