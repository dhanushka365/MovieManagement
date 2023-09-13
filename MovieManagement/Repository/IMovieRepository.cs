using MovieManagement.Entities;

namespace MovieManagement.Repository
{
    public interface IMovieRepository:IGenreRepository<Movie>
    {
    }
}
