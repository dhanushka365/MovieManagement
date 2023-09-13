namespace MovieManagement.Entities
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public List<Movie> Movies { get; set; } = default!;//(1,*)
    }
}
