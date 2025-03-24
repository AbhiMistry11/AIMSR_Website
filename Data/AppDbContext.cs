// Data/AppDbContext.cs
using AIMSRCollegeWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AIMSRCollegeWebsite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ContactQuery> ContactQueries { get; set; }
    }
}