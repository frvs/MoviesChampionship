namespace Domain.Entities.Movies
{
    public class MovieMatchResult
    {
        public MovieMatchResult(Movie firstMovie, Movie secondMovie)
        {
            FirstPlace = firstMovie;
            SecondPlace = secondMovie;
        }

        public Movie FirstPlace { get; set; }
        public Movie SecondPlace { get; set; }

    }
}
