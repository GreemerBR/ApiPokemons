using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiPokemons.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : GenericController<Pokemon>
    {
    }
}
