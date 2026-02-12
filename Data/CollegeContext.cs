using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using College.Models;

namespace College.Data
{
    public class CollegeContext : DbContext
    {
        public CollegeContext (DbContextOptions<CollegeContext> options)
            : base(options)
        {
        }

        public DbSet<College.Models.Course> Course { get; set; } = default!;
        public DbSet<College.Models.Department> Department { get; set; } = default!;
        public DbSet<College.Models.Instructor> Instructor { get; set; } = default!;
        public DbSet<College.Models.Delinquent> Delinquent { get; set; } = default!;
    }
}
