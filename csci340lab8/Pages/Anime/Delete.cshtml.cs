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
    public class DeleteModel : PageModel
    {
        private readonly csci340lab8.Data.csci340lab8AnimeContext _context;

        public DeleteModel(csci340lab8.Data.csci340lab8AnimeContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Anime == null)
            {
                return NotFound();
            }
            var anime = await _context.Anime.FindAsync(id);

            if (anime != null)
            {
                Anime = anime;
                _context.Anime.Remove(Anime);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
