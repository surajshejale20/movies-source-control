using System;
using System.Collections.Generic;
using System.Text;
using Movies.Entities;

namespace Movies.Services
{
    public interface IMovieService
    {
        public IList<Movie> GetAllMovies();
        public List<Movie> GetMovieByTitle(string title);
    }
}
