using MovieManagement.Entities;

namespace MovieManagement.Repository
{
    public interface IActorRepository:IGenreRepository<Actor>
    {

    }

    public interface IGenreRepository<T>
    {
    }
}
