namespace MovieManagement.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;


        public int ? ActorId { get; set; }

        public List<Actor> Actor { get; set; } = default!;

        public List<Genre> Genres { get; set; } = default!;
    }
}
