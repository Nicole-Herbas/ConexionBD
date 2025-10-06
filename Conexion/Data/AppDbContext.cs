using System.Collections.Generic;
using System.Reflection.Emit;
using Conexion.Models;
using Microsoft.EntityFrameworkCore;

namespace Conexion.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Event> Books => Set<Event>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.Title).IsRequired().HasMaxLength(200);
                b.Property(x => x.Capacity).IsRequired();
                b.Property(x => x.Date).IsRequired();
            });
        }
    }
}