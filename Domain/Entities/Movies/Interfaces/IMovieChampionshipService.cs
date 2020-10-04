using System.Collections.Generic;

namespace Domain.Entities.Movies.Interfaces
{
    public interface IMovieChampionshipService
    {
        MovieMatchResult GetChampionshipResult(List<Movie> movies);
    }
}
