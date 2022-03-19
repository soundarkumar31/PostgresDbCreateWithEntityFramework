using Microsoft.EntityFrameworkCore;
using PostgresDbCreate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgresDbCreate.Migrations
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext()
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseNpgsql("Server=localhost;Port=5434;Database=MyDatabase;User Id=postgres;Password=918508973252");
    }
}
