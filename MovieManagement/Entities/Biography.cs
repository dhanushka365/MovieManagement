namespace MovieManagement.Entities
{
    public class Biography
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public int ActorId { get; set; }

        public Actor Actor { get; set; } = default!;
    }
}
