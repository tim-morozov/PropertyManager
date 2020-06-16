using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PropertyManager.Models;

namespace PropertyManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Analyst> Analysts { get; set; }
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

