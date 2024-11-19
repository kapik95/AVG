using AVG.Models;
using Microsoft.EntityFrameworkCore;

namespace AVG.Data
{
    public class ProjectsDbContext(DbContextOptions<ProjectsDbContext> options) : DbContext(options)
    {
        public DbSet<ProjectModel> ProjectsModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=local.db");
        }
    }
}
