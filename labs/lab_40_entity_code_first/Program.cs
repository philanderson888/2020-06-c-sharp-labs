using lab_40_entity_code_first.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace lab_40_entity_code_first
{
    class Program
    {
        static void Main(string[] args)
        {

            List<User> users = new List<User>();
            List<Category> categories = new List<Category>();

            using(var db = new UserDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                users = db.Users.ToList();
                categories = db.Categories.ToList();

                // add an item - note that AUTOINCREMENT IS ON.
                //var user = new User()
                //{
                //    Username = "Some User"
                //};
                //db.Users.Add(user);
                //db.SaveChanges();


                // refresh users
                users = db.Users.Include("Category").ToList();

                users.ForEach(user => Console.WriteLine($"User {user.UserId} {user.Username} has " +
                    $"date of birth {user.DateOfBirth} with category {user.Category.CategoryName}"));

                categories.ForEach(c => Console.WriteLine($"Category {c.CategoryId,-10}{c.CategoryName}"));

                

            }
        }
    }



}
