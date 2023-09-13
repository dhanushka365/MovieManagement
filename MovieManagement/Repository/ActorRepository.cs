using MovieManagement.Data;
using MovieManagement.Entities;

namespace MovieManagement.Repository
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(MovieContext context) : base(context)
        {
        }
    }
}
