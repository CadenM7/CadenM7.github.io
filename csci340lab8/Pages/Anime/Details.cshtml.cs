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
    public class DetailsModel : PageModel
    {
        private readonly csci340lab8.Data.csci340lab8AnimeContext _context;

        public DetailsModel(csci340lab8.Data.csci340lab8AnimeContext context)
        {
            _context = context;
        }

      public Anime Anime { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Anime == null)
            {
                return NotFound();
            }

            var anime = await _context.Anime.FirstOrDefaultAsync(m => m.Id == id);
            if (anime == null)
            {
                return NotFound();
            }
            else 
            {
                Anime = anime;
            }
            return Page();
        }
    }
}
