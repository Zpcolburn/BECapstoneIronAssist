using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Services;
using Microsoft.AspNetCore.Mvc;

namespace BECapstoneIronAssist.Endpoints
{
    public class JobsiteEndpoints
    {
        public static void Map(WebApplication app)
        {
            // Get All Jobsites
            app.MapGet("/jobsites", async (IJobsiteService jobsiteService) =>
            {
                return await jobsiteService.GetAllJobsitesAsync();
            });

            // Get Single Jobsite
            app.MapGet("/jobsite/{id}", async (IJobsiteService jobsiteService, int id) =>
            {
                var jobsite = await jobsiteService.GetSingleJobsiteAsync(id);
                if (jobsite == null)
                {
                    return Results.NotFound("Jobsite not found");
                }
                return Results.Ok(jobsite);
            });
        }
    }
}
