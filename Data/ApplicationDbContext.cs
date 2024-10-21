using Microsoft.EntityFrameworkCore;
using StateMaster.Models.Entites;

namespace StateMaster.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<State> States { get; set; }


    }

}
