using System;
using System.Collections.Generic;
using System.Text;
using CarMarketWithLogin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarMarketWithLogin.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=123456789;database=CarMarketWithLogin", 
                new MySqlServerVersion(new Version(8, 0, 11))
            );
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; } 
        public DbSet<Capacity> Capacities { get; set; }
        public DbSet<DriveUnit> DriveUnits { get; set; }
        public DbSet<EngineType> EngineTypes { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Img> Imgs{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<BookMark> BookMarks { get; set; }
    }
}