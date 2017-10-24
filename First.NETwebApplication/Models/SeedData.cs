using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace First.NETwebApplication.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FirstNETwebApplicationContext(
                serviceProvider.GetRequiredService<DbContextOptions<FirstNETwebApplicationContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return; //DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = " When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-1-11"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = " IT",
                        ReleaseDate = DateTime.Parse("2017-9-8"),
                        Genre = "Drama Thriller",
                        Price = 17.99M
                    },

                    new Movie
                    {
                        Title = "The House",
                        ReleaseDate = DateTime.Parse("2017-6-30"),
                        Genre = "Comedy",
                        Price = 4.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
