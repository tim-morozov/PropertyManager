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
            builder.Entity<Property>().HasData(new Property { Id = 1, Name = "House1", Address = "2741 N 40th St", City = "Milwaukee", State = "WI", ZipCode = "53210" });
            builder.Entity<Property>().HasData(new Property { Id = 2, Name = "House2", Address = "1531 N 29th St Unit 1533", City = "Milwaukee", State = "WI", ZipCode = "53208" });
            builder.Entity<Property>().HasData(new Property { Id = 3, Name = "House3", Address = "4546 N 70th St", City = "Milwaukee", State = "WI", ZipCode = "53218" });
            builder.Entity<Property>().HasData(new Property { Id = 4, Name = "House4", Address = "1962 S 12th St", City = "Milwaukee", State = "WI", ZipCode = "53204" });
            builder.Entity<Property>().HasData(new Property { Id = 5, Name = "House5", Address = "4183 N 13th St", City = "Milwaukee", State = "WI", ZipCode = "53209" });
            builder.Entity<Property>().HasData(new Property { Id = 6, Name = "River Place", Address = "4201 W Hawthorne Trace Rd", City = "Milwaukee", State = "WI", ZipCode = "53209" });
            builder.Entity<Property>().HasData(new Property { Id = 7, Name = "DoMUS", Address = "441 E Erie St", City = "Milwaukee", State = "WI", ZipCode = "53202" });
            builder.Entity<Property>().HasData(new Property { Id = 8, Name = "GlenBrook", Address = "9220 N 75th St", City = "Milwaukee", State = "WI", ZipCode = "53223" });
            builder.Entity<Property>().HasData(new Property { Id = 9, Name = "North End", Address = "1551 N Water St", City = "Milwaukee", State = "WI", ZipCode = "53202" });
            builder.Entity<Property>().HasData(new Property { Id = 10, Name = "Stonewell", Address = "2634 North Stowell Avenue", City = "Milwaukee", State = "WI", ZipCode = "53211" });
            }
    }
}

