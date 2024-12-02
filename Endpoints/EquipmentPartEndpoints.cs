using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Services;
using Microsoft.AspNetCore.Mvc;

namespace BECapstoneIronAssist.Endpoints
{
    public class EquipmentPartEndpoints
    {
        public static void Map(WebApplication app)
        {
            // Post(Add) EquipmentPart
            app.MapPost("/equipmentPart/{equipmentId}/{partId}", async (int equipmentId, int partId, IEquipmentPartService equipmentPartService) =>
            {
                var result = await equipmentPartService.AddEquipmentPartAsync(equipmentId, partId);
                return Results.Created($"/equipmentPart/{result.EquipmentId}/{result.PartId}", result);
            });

            // Put(Edit) EquipmentPart
            app.MapPut("/equipmentPart/{equipmentId}/{partId}", async (int equipmentId, int partId, EquipmentPart updatedEquipmentPart, IEquipmentPartService equipmentPartService) =>
            {
                var partToUpdate = await equipmentPartService.UpdateEquipmentPartAsync(equipmentId, partId, updatedEquipmentPart);
                if (partToUpdate == null)
                {
                    return Results.NotFound("EquipmentPart not found.");
                }
                return Results.Ok(partToUpdate);
            });

            // Delete EquipmentPart
            app.MapDelete("/equipmentPart/{equipmentId}/{partId}", async (int equipmentId, int partId, IEquipmentPartService equipmentPartService) =>
            {
                var result = await equipmentPartService.DeleteEquipmentPartAsync(equipmentId, partId);
                if (result == null)
                {
                    return Results.NotFound("EquipmentPart not found.");
                }
                return Results.Ok(result);
            });
        }
    }
}
