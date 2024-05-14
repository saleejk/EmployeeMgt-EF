using EmployeeMgt_EF.ModelEntity;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMgt_EF.Data
{
    public class DbContextClass:DbContext
    {
        public readonly IConfiguration _config;
        public string connectionString;
        public DbContextClass (IConfiguration config)
        {
            _config= config;
            connectionString = _config["ConnectionStrings:DefaultConnection"];
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }       
        public DbSet<Employee> Employees {  get; set; }

    }
}
