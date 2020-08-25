using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_48_to_do_app.Models
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<User> Users { get; set; }

        public ToDoDbContext() { }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options) { }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // relationships - one user has many todo items
            builder.Entity<User>()
                .HasMany(user => user.ToDos)
                .WithOne(user => user.User);
            // username is required
            builder.Entity<User>()
                .Property(user => user.UserName)
                .IsRequired();
            // seed data
            builder.Entity<User>().HasData(
                new User { UserId = 1, UserName = "Bob" },
                new User { UserId = 2, UserName = "Fred" },
                new User { UserId = 3, UserName = "Alice" }
            );
            builder.Entity<ToDo>().HasData(
                new ToDo { ToDoId = 1 , ToDoName = "Do something useful", UserId = 2},
                new ToDo { ToDoId = 2 , ToDoName = "Some other task", UserId = 3 },
                new ToDo { ToDoId = 3 , ToDoName = "A third task", UserId=1 }
            );
        }

       

    }
}
