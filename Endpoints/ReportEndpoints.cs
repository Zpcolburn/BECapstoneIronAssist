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

            // Post(Create) New Report
            app.MapPost("/report", async (IReportService reportService, Report newReport) =>
            {
                return await reportService.AddReportAsync(newReport);
            });

            // Put(Edit) Report
            app.MapPut("/report/{id}", async (IReportService reportService, int id, Report updatedReport) =>
            {
                return await reportService.UpdateSingleReportAsync(id, updatedReport);
            });
        }
    }
}
