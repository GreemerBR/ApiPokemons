using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiPokemons.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private PokemonRepository _repository;

        public PokemonController()
        {
            this._repository = new PokemonRepository();
        }

        [HttpGet(Name = "Pokemon")]
        public List<Pokemon> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Pokemon GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public string Post(Pokemon model)
        {
            return _repository.Create(model);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _repository.Delete(id);
        }

        [HttpPut]
        public string Update(Pokemon model)
        {
            return _repository.Update(model);
        }
    }
}
