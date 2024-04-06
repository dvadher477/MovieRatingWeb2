namespace MovieRatingWeb.Models
{
    using System.Collections.Generic;

    public class TVresponse
    {
        public List<Tv> Results { get; set; }
    }

    public class Tv
    {
        public string name { get; set; }

        public string vote_average { get; set; }

        public string poster_path { get; set; }
    }
    public class TVModels
    {

    }
}
