using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroesController : ControllerBase
    {
        private readonly ISuperHeroesService _superHeroesService;
        public SuperHeroesController(ISuperHeroesService superHeroesService)
        {
            _superHeroesService = superHeroesService;    
        }

        [HttpGet]

        public async Task<IActionResult> GetAsync()
        {
            var results = await _superHeroesService.GetSuperHeroesAsync();
            return Ok(results);
        }
    }
}
