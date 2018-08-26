using BetssonGroup.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetssonGroup.Data
{
    public class BetssonGroupDbContext : DbContext
    {
        public BetssonGroupDbContext(DbContextOptions<BetssonGroupDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
