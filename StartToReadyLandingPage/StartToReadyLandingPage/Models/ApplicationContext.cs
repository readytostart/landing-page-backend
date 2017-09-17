using Microsoft.EntityFrameworkCore;

namespace StartToReadyLandingPage.Models {
    public class ApplicationContext : DbContext {
        public ApplicationContext(DbContextOptions opts) : base(opts) {
        }

        public DbSet<Lead> Leads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.Entity<Lead>()
                .Property(l => l.EhAluno)
                .HasColumnType("bit");
            builder.Entity<Lead>()
                .Property(l => l.Empresa)
                .HasColumnType("int");
        }
    }
}