using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using csci340lab8.Models;

namespace csci340lab8.Data
{
    public class csci340lab8AnimeContext : DbContext
    {
        public csci340lab8AnimeContext (DbContextOptions<csci340lab8AnimeContext> options)
            : base(options)
        {
        }

        public DbSet<csci340lab8.Models.Anime> Anime { get; set; } = default!;
    }
}
