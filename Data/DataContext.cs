using Microsoft.EntityFrameworkCore;
using TrainingApplication.Entities;

namespace TrainingApplication.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<AutoInsurance> AutoInsurances { get; set; }

        public DbSet<HomeInsurance> HomeInsurances { get; set; }
    }
}
