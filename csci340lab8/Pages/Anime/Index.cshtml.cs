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

        public async Task OnGetAsync()
        {
            if (_context.Anime != null)
            {
                Anime = await _context.Anime.ToListAsync();
            }
        }
    }
}
