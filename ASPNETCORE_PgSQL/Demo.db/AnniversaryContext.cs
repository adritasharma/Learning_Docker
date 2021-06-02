using Demo.db.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.db
{
    public class AnniversaryContext : DbContext
    {
        public AnniversaryContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Occasion> Occasions { get; set; }
        public DbSet<OccasionType> OccasionTypes { get; set; }
    }
}
