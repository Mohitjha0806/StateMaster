using Microsoft.EntityFrameworkCore;
using StateMaster.Models.Entites;

namespace StateMaster.Data
{
    public class ApplicationDbContext : DbContext
    {
     
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<State> State { get; set; }

    }

}
