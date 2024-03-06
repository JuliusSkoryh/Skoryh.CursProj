using Microsoft.EntityFrameworkCore;
using Domain.Enteties;


namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Pass> Passes { get; set; }
        public DbSet<AccessLevel> AccessLevels { get; set; }
        public DbSet<Checkpoint> Checkpoints { get; set; }
        public DbSet<Report> Reports { get; set; }

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Host=localhost;Port=5432;Database=Check;Username=postgres;Password=password
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Check;Username=postgres;Password=password");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessLevel>()
                .HasMany(a => a.Passes)
                .WithOne(a => a.AccessLevel)
                .HasForeignKey(a => a.AccessLevelId)
                .IsRequired();

            modelBuilder.Entity<AccessLevel>()
                .HasMany(a => a.Checkpoints)
                .WithOne(a => a.AccessLevel)
                .HasForeignKey(a => a.AccessLevelId)
                .IsRequired();

            modelBuilder.Entity<Employee>()
                .HasOne(a => a.Pass)
                .WithOne(a => a.Employee)
                .HasForeignKey<Pass>(a => a.EmployeeId)
                .IsRequired(false);

            modelBuilder.Entity<Pass>()
                .HasMany(p => p.Reports)
                .WithOne(p => p.Pass)
                .HasForeignKey(p => p.PassId)
                .IsRequired();

            modelBuilder.Entity<Checkpoint>()
                .HasMany(p => p.Reports)
                .WithOne(p => p.Checkpoint)
                .HasForeignKey(p => p.CheckpointId)
                .IsRequired();
        }
    }
}
