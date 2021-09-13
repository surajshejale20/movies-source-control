using System;
using System.Collections.Generic;
using System.Text;
using Movies.Entities;
using Movies.Repository;

namespace Movies.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public IList<Movie> GetAllMovies()
        {
            return _movieRepository.GetAll();
        }

        public List<Movie> GetMovieByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
