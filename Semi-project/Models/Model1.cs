using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Semi_project.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.Dept_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.Dept_ID);

            modelBuilder.Entity<Employee>()
                .Property(e => e.name_)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.salary)
                .HasPrecision(19, 4);
        }
    }
}
