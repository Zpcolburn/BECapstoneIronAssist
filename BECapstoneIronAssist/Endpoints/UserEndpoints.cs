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
            // Get All Users
            app.MapGet("/users", async (IUserService userService) =>
            {
                return await userService.GetAllUsersAsync();
            });

            // User Check
            app.MapGet("/users/checkUser/{uid}", async ([FromServices] IUserService userService, string uid) =>
            {
                var user = await userService.CheckUserAsync(uid);
                if (user == null) 
                {
                    return Results.NotFound("User not found");
                }
                return Results.Ok(user);
            });

            // Get Single User
            app.MapGet("/users/{id}", async (IUserService userService, int id) =>
            {
                var user = await userService.GetSingleUserAsync(id);
                if (user == null) 
                {
                    return Results.NotFound("User not found");
                }
                return Results.Ok(user);
            });

            // Post(Add) New User
            app.MapPost("/users", async (IUserService userService, User user) =>
            {
                var newUser = await userService.AddUserAsync(user);
                return Results.Created($"/users/{newUser.Id}", newUser);
            });

            // Update Single User
            app.MapPut("/users/{id}", async (IUserService userService, int id, User updatedUser) =>
            {
                var userToUpdate = await userService.UpdateSingleUserAsync(id, updatedUser);
                return Results.Ok(userToUpdate);
            });
        }
    }
}
