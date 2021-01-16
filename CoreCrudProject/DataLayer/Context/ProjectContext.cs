using CoreCrudProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrudProject.DataLayer.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
            // We were writing our database connection clause here in standard .Net. Things have changed a bit in Core. Since Asp .Net Core directs us to reduce dependencies in every phase, we are now using the DI principle of reducing dependencies in ProjectContext.cs class.
        }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
