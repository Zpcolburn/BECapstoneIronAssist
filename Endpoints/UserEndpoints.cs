using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Services;
using Microsoft.AspNetCore.Mvc;

namespace BECapstoneIronAssist.Endpoints
{
    public class UserEndpoints
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/users", async (IUserService userService) =>
            {
                return await userService.GetAllUsersAsync();
            });
        }
    }
}
