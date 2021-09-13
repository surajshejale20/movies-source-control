using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Repository.Infrastructure
{
    public static class RepositoryConfigurator
    {
        public static IServiceCollection AddRepositories(this IServiceCollection repositoryCollection)
        {
            return repositoryCollection.AddTransient<IMovieRepository, MovieRepository>();
        }
    }
}
