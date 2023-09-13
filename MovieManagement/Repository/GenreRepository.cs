using MovieManagement.Data;
using MovieManagement.Entities;

namespace MovieManagement.Repository
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(MovieContext context) : base(context)
        {
        }
    }
}
