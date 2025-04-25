using WebAPI.Data.Entities;

namespace WebAPI.Services
{
    public interface ISuperHeroesService
    {
        Task<List<SuperHeroes>> GetSuperHeroesAsync();
    }
}
