using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab_40_entity_code_first.Models
{
    class UserDbContext : DbContext
    {
        // map class to table with DbSet
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        // no Startup.cs so => connect to database HERE!
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite("DataSource=UserDatabase.db");
        }

        // NOTE - HAVE TO ADD ID HERE
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(new User { UserId = 1, Username = "some user" , DateOfBirth = new DateTime(2020,08,09), CategoryId=1});
            builder.Entity<User>().HasData(new User { UserId = 2, Username = "another user" , DateOfBirth = new DateTime(2020,10,10),CategoryId=2});
            builder.Entity<User>().HasData(new User { UserId = 3, Username = "an extra super user" , DateOfBirth = new DateTime(2020,09,07),CategoryId=3});

            builder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Admin" });
            builder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Database" });
            builder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Standard" });

          
        }
    }
}
