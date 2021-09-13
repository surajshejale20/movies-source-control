using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services.Infrastructure
{
    public static class ServiceConfigurator
    {
        public static IServiceCollection AddServices(this IServiceCollection repositoryCollection)
        {
            return repositoryCollection.AddTransient<IMovieService, MovieService>();
        }
    }
}
