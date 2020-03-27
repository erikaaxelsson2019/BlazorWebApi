using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entites
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Case)
                .WithOne(t => t.Customer)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<CaseStatus> CaseStatus { get; set; }

        public DbSet<Caseworker> Caseworkers { get; set; }

        public DbSet<Case> Cases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
