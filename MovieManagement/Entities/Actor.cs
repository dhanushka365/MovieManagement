﻿namespace MovieManagement.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public List<Movie>? Movies { get; set; }  

        public Biography? Biography { get; set; }
    }
}
