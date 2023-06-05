using Microsoft.EntityFrameworkCore;

namespace asp_project.Models
{
    public class StepsContext : DbContext
    {
        public StepsContext(DbContextOptions<StepsContext>options) : base(options)
        {

        }
        public DbSet<Steps> Steps { get; set; }
    }
}
