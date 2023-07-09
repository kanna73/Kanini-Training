using Microsoft.EntityFrameworkCore;

namespace WebAPICODEFIRST.Model.Data
{
    public class BikeDataContext:DbContext
    {
        public DbSet<User>  Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Bike> Bikes { get; set; }


        public BikeDataContext(DbContextOptions<BikeDataContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
