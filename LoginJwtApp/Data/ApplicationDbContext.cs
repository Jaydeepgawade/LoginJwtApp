using LoginJwtApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginJwtApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        #region Ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
        #endregion

        #region Field
        public DbSet<User> Users { get; set; }

        #endregion
    }
}
