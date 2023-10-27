using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using csci340lab8.Data;
using csci340lab8.Models;

namespace csci340lab8.Pages_Anime
{
    public class IndexModel : PageModel
    {
        private readonly csci340lab8.Data.csci340lab8AnimeContext _context;

        public IndexModel(csci340lab8.Data.csci340lab8AnimeContext context)
        {
            _context = context;
        }

        public IList<Anime> Anime { get;set; } = default!;

         [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

        public async Task OnGetAsync()
{
    // Use LINQ to get list of genres.
    IQueryable<string> genreQuery = from m in _context.Anime
                                    orderby m.Genre
                                    select m.Genre;

    var animes = from a in _context.Anime
                 select a;

    if (!string.IsNullOrEmpty(SearchString))
    {
        animes = animes.Where(s => s.Title.Contains(SearchString));
    }

    if (!string.IsNullOrEmpty(MovieGenre))
    {
        animes = animes.Where(x => x.Genre == MovieGenre);
    }
    Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
    Anime = await animes.ToListAsync();
}
    }
}
