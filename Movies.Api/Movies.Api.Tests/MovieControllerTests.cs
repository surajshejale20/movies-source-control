using Moq;
using Movies.Api.Controllers;
using Movies.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Movies.Entities;
using Xunit;

namespace Movies.Api.Tests
{
    public class MovieControllerTests
    {
        private readonly Mock<IMovieService> _movieServiceMock;
        private readonly MovieController _sut;
        public MovieControllerTests()
        {
            _movieServiceMock = new Mock<IMovieService>();
            _sut = new MovieController(_movieServiceMock.Object);
        }

        [Fact]
        public void GetAllMovies_ShouldReturnNoContent_WhenNoDataAvailable()
        {
            _movieServiceMock.Setup(x => x.GetAllMovies()).Returns(new List<Movie>());
            var result = _sut.GetAllMovies();
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public void GetAllMovies_ShouldReturnOk_WhenRecordsFound()
        {
            _movieServiceMock.Setup(x => x.GetAllMovies()).Returns(new List<Movie>() {new Movie { }, new Movie { }});
            var result = _sut.GetAllMovies();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetAllMovies_ShouldCallServiceMethodGetAllMovies()
        {
            _movieServiceMock.Setup(x => x.GetAllMovies()).Returns(new List<Movie>());
            _sut.GetAllMovies();
            _movieServiceMock.Verify(x=>x.GetAllMovies(), Times.Once);
        }
    }
}
