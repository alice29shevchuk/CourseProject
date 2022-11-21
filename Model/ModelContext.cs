using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CourseProject
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=Model1")
        {
        }

        public virtual DbSet<AdminBas> AdminBases { get; set; }
        public virtual DbSet<LoginPassword> LoginPasswords { get; set; }
        public virtual DbSet<NameOfRole> NameOfRoles { get; set; }
        public virtual DbSet<RecordsBas> RecordsBases { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<TypeOfService> TypeOfServices { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NameOfRole>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.NameOfRole)
                .HasForeignKey(e => e.NameRoleIDNavigationId);
        }
    }
}
