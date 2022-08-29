using Data.Context;
using Data.Model;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual string Create(T entity)
        {
            using (PokemonContext pokemonContext = new PokemonContext())
            {
                pokemonContext.Set<T>().Add(entity);
                pokemonContext.SaveChanges();
            }
            return "Pokemon adicionado ao banco de dados com sucesso!";
        }

        public virtual string Delete(int id)
        {
            T entity = GetById(id);

            using (PokemonContext pokemonContext = new PokemonContext())
            {
                pokemonContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                pokemonContext.SaveChanges();
            }
            return "Pokemon deletado do banco de dados com sucesso!";
        }

        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();

            using(PokemonContext pokemonContext = new PokemonContext())
            {
                list = pokemonContext.Set<T>().ToList();
            }

            return list;
        }

        public virtual T GetById(int id)
        {
           T entity = null;

            using (PokemonContext pokemonContext = new PokemonContext())
            {
                entity = pokemonContext.Set<T>().Find(id);
            }

            return entity;
        }

        public virtual string Update(T entity)
        {
            using (PokemonContext pokemonContext = new PokemonContext())
            {
                pokemonContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                pokemonContext.SaveChanges();
            }
            return "Pokemon editado no banco de dados com sucesso!";
        }
    }
}
