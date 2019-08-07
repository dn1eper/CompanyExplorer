using System.Data.Entity;
using CompanyExplorer.Model;

namespace CompanyExplorer
{
    public partial class CompanyContext : DbContext
    {
        public CompanyContext() : base("name=Company")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Empoyee> Empoyees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(e => e.Department1)
                .WithOptional(e => e.Department2)
                .HasForeignKey(e => e.ParentDepartmentID);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Empoyees)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empoyee>()
                .Property(e => e.ID)
                .HasPrecision(5, 0);
        }
    }
}
