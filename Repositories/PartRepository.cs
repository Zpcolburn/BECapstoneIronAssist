﻿using BECapstoneIronAssist.Interfaces;
using BECapstoneIronAssist.Models;
using Microsoft.EntityFrameworkCore;

namespace BECapstoneIronAssist.Repositories
{
    public class PartRepository : IPartRepository
    {
        private readonly BECapstoneIronAssistDbContext dbContext;

        public PartRepository(BECapstoneIronAssistDbContext context)
        {
            dbContext = context;
        }
        public async Task<List<Part>> GetAllPartAsync()
        {
            return await dbContext.Parts.ToListAsync();
        }
        public Task<Part> GetSinglePartAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Part> AddPartAsync(Part newPart)
        {
            throw new NotImplementedException();
        }
        public Task<Part> UpdateSinglePartAsync(int id, Part updatePart)
        {
            throw new NotImplementedException();
        }
        public Task<Part> DeleteSinglePartAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
