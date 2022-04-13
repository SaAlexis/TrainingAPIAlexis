using TrainApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace TrainApp.Persistence
{
    public class SqlDbContext : DbContext
    {

        //public SqlDbContext(DbContextOptions<SqlDbContext> options)
        //    : base(options)
        //{

        //}

        public SqlDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-KN0N952\ALEXPRESS;User id=sa;Password = mdpbdd;Initial Catalog=TrainAPI;Integrated Security=True;");
        }

        public DbSet<UserEntity> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
