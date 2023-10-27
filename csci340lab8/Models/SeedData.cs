using Microsoft.EntityFrameworkCore;
using csci340lab8.Data;

namespace csci340lab8.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new csci340lab8AnimeContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<csci340lab8AnimeContext>>()))
        {
            if (context == null || context.Anime == null)
            {
                throw new ArgumentNullException("Null RazorPagesAnContext");
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