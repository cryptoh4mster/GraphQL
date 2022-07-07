using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Entities;
using Microsoft.EntityFrameworkCore;


namespace GraphQL.EF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Company> Companies { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasMany(p => p.Persons)
                .WithOne(b => b.Company!)
                .HasForeignKey(p => p.CompanyId);

            modelBuilder.Entity<Person>()
                .HasOne(p => p.Company)
                .WithMany(b => b.Persons)
                .HasForeignKey(p => p.CompanyId);
        }
    }
}
