﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using lab_47_mvc.Models;

namespace lab_47_mvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<lab_47_mvc.Models.College> College { get; set; }
        public DbSet<lab_47_mvc.Models.Student> Student { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<College>()
                .HasKey(college => college.CollegeId);

            builder.Entity<College>()
                .Property(college => college.CollegeName)
                .IsRequired();


        }

    }
}
