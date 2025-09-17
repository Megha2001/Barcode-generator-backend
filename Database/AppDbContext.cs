using BarcodeFinal.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace BarcodeFinal.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Template> Templates { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasOne<Template>()
                .WithMany()
                .HasForeignKey(p => p.TemplateReferenceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
