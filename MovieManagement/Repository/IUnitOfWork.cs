﻿namespace MovieManagement.Repository
{
    public interface IUnitOfWork:IDisposable
    {
        IActorRepository Actors { get; }
        IMovieRepository Movies { get; }
        IBiographyRepository Biographies { get; }
        IGenreRepository Genres { get; }
        int save();
    }
}
