using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Services;
using Microsoft.AspNetCore.Mvc;

namespace BECapstoneIronAssist.Endpoints
{
    public class PartEndpoints
    {
        public static void Map(WebApplication app)
        {
            // Get All Parts
            app.MapGet("/parts", async (IPartService partService) =>
            {
                return await partService.GetAllPartAsync();
            });

            // Get Single Part by Id
            app.MapGet("/part/{id}", async (IPartService partService, int id) =>
            {
                var part = await partService.GetSinglePartAsync(id);
                if (part == null)
                {
                    return Results.NotFound("Part not found");
                }
                return Results.Ok(part);
            });

            // Post(Add) New Part
            app.MapPost("/part", async (IPartService partService, Part part) =>
            {
                var newPart = await partService.AddPartAsync(part);
                return Results.Created($"/part/{newPart.Id}", newPart);
            });
        }
    }
}
