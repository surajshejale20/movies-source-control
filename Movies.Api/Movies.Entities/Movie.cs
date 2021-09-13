using System.Collections.Generic;

namespace Movies.Entities
{
    public class Movie
    {
        public string Language { get; set; }
        public string Location { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        public List<string> SoundEffects { get; set; }
        public List<string> Stills { get; set; }
        public string Title { get; set; }
        public string IMDBId { get; set; }
        public string ListingType { get; set; }
        public double IMDBRating { get; set; }

        public Movie()
        {
            SoundEffects = new List<string>();
            Stills = new List<string>();
        }
    }
}
