﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PropertyManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(new IdentityRole{ Name = "Admin", NormalizedName = "ADMIN"});
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Tenant", NormalizedName = "TENANT" });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Contractor", NormalizedName = "CONTRACTOR" });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Analyst", NormalizedName = "ANALYST" });
        }
    }
}

