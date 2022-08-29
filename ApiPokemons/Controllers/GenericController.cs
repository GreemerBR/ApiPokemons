using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiPokemons.Controllers
{
    public class GenericController<T> : ControllerBase where T : BaseModel
    {
        private BaseRepository<T> _repository;

        public GenericController()
        {
            this._repository = new BaseRepository<T>();
        }

        [HttpGet]
        public List<T> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public string Post(T model)
        {
            return _repository.Create(model);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _repository.Delete(id);
        }

        [HttpPut]
        public string Update(T model)
        {
            return _repository.Update(model);
        }
    }
}
