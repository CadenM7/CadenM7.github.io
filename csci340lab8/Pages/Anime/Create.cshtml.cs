using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using csci340lab8.Data;
using csci340lab8.Models;

namespace csci340lab8.Pages_Anime
{
    public class CreateModel : PageModel
    {
        private readonly csci340lab8.Data.csci340lab8AnimeContext _context;

        public CreateModel(csci340lab8.Data.csci340lab8AnimeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Anime Anime { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Anime == null || Anime == null)
            {
                return Page();
            }

            _context.Anime.Add(Anime);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
