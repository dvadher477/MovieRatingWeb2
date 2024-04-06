namespace MovieRatingWeb.Models
{
    using System.Collections.Generic;

    public class MovieResponse
    {
        public List<Movie> Results { get; set; }
    }

    public class Movie
    {
        public string Title { get; set; }

        public string vote_average { get; set; }

        public string poster_path { get; set; }
    }
    public class MovieModels
    {

    }
}
