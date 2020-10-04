using Domain.Entities.Movies;
using Domain.Entities.Movies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Services.Movies
{
    public class MovieChampionshipService : IMovieChampionshipService
    {
        public MovieMatchResult GetChampionshipResult(List<Movie> movies)
        {
            ValidateMovies(movies);

            var firstWinner = MatchMovies(movies[0], movies[7]).FirstPlace;
            var secondWinner = MatchMovies(movies[1], movies[6]).FirstPlace;
            var thirdWinner = MatchMovies(movies[2], movies[5]).FirstPlace;
            var fourthWinner = MatchMovies(movies[3], movies[4]).FirstPlace;

            var fifthWinner = MatchMovies(firstWinner, secondWinner).FirstPlace;
            var sixthWinner = MatchMovies(thirdWinner, fourthWinner).FirstPlace;

            var firstPlace = MatchMovies(fifthWinner, sixthWinner).FirstPlace;
            var secondPlace = MatchMovies(fifthWinner, sixthWinner).SecondPlace;

            return new MovieMatchResult(firstPlace, secondPlace);
        }

        public MovieMatchResult MatchMovies(Movie firstMovie, Movie secondMovie)
        {
            if(firstMovie.Rate == secondMovie.Rate)
            {
                var alphabeticallySortedMovies = new List<Movie> { firstMovie, secondMovie }.OrderBy(movie => movie.Name).ToList();

                return new MovieMatchResult(alphabeticallySortedMovies[0], alphabeticallySortedMovies[1]);
            }

            if (firstMovie.Rate > secondMovie.Rate)
            {
                return new MovieMatchResult(firstMovie, secondMovie);
            } 
            else
            {
                return new MovieMatchResult(secondMovie, firstMovie);
            }
        }


        private void ValidateMovies(List<Movie> movies)
        {
            if(movies == null || movies.Count != 8)
            {
                throw new Exception("A quantidade de filmes deve ser igual a 8.");
            }
        }
    }
}
