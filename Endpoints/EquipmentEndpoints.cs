using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Services;
using Microsoft.AspNetCore.Mvc;

namespace BECapstoneIronAssist.Endpoints
{
    public class EquipmentEndpoints
    {
        public static void Map(WebApplication app)
        {
            // Get All Equipment 
            app.MapGet("/equipment", async (IEquipmentService equipmentService) =>
            {
                return await equipmentService.GetAllEquipmentAsync();
            });

            // Get Single Equipment
            app.MapGet("/equipment/{id}", async (IEquipmentService equipmentService, int id) =>
            {
                var equipment = await equipmentService.GetSingleEquipmentAsync(id);
                if (equipment == null)
                {
                    return Results.NotFound("Equipment not found");
                }
                return Results.Ok(equipment);
            });

            // Post New Equipment
            app.MapPost("/equipment", async (IEquipmentService equipmentService, Equipment equipment) =>
            {
                var newEquipment = await equipmentService.AddEquipmentAsync(equipment);
                return Results.Created($"/equipment/{newEquipment.Id}", newEquipment);
            });
        }
    }
}
