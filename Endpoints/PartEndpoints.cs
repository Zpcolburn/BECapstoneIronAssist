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
        }
    }
}
