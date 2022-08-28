using Microsoft.EntityFrameworkCore;

namespace ProPersonalApi.DataAccessLayer
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-TLTN1FO;database = ProPersonalApiDb; integrated security=true");
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
