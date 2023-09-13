using MovieManagement.Data;
using MovieManagement.Entities;

namespace MovieManagement.Repository
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieContext context) : base(context)
        {
        }
    }
}
