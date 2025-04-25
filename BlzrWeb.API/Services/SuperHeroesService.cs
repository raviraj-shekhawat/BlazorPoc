using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Data.Entities;

namespace WebAPI.Services
{
    public class SuperHeroService : ISuperHeroesService
    {
        private readonly BlzrDbContext _blzrDbContext;

        public SuperHeroService(BlzrDbContext blzrDbContext)
        {
            _blzrDbContext = blzrDbContext;
        }

        public async Task<List<SuperHeroes>> GetSuperHeroesAsync()
        {
            return await _blzrDbContext.SuperHeroes.ToListAsync();
        }
    }
}
