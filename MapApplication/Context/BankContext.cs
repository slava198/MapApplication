using MapApplication.Entities;
using System.Data.Entity;


namespace MapApplication.Context
{
    class BankContext : DbContext
    {
        public BankContext() : base("DbConnection")
        {

        }

        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Departmen> Departments { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
    }
}
