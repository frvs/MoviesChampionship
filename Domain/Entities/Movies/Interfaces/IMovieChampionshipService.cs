using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Movies.Interfaces
{
    public interface IMovieChampionshipService
    {
        List<Movie> MatchMovies(List<Movie> movies);
    }
}
