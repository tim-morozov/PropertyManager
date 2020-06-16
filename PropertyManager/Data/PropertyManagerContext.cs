using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PropertyManager.Models;

namespace PropertyManager.Data
{
    public class PropertyManagerContext : DbContext
    {
        public PropertyManagerContext (DbContextOptions<PropertyManagerContext> options)
            : base(options)
        {
        }

        public DbSet<PropertyManager.Models.Tenant> Tenant { get; set; }

        public DbSet<PropertyManager.Models.Contractor> Contractor { get; set; }

        public DbSet<PropertyManager.Models.Admin> Admin { get; set; }

        public DbSet<PropertyManager.Models.Analyst> Analyst { get; set; }
    }
}
