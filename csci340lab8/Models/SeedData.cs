using Microsoft.EntityFrameworkCore;
using csci340lab8.Data;

namespace csci340lab8.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesMovieContext>>()))
        {
            if (context == null || context.Movie == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Anime.Any())
            {
                return;   // DB has been seeded
            }

            context.Anime.AddRange(
            );
            context.SaveChanges();
        }
    }
}