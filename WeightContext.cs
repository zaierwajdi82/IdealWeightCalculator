using Microsoft.EntityFrameworkCore;


namespace IdealWeightCalculator
{
    public class WeightContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localDB)\\MSSQLLocalDB; DataBase=WeightDB; integrated security=true; ");
        }
    }
}
