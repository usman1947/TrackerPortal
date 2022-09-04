namespace WebApi.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to postgres with connection string from app settings
        options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
    }

    #region Auditable
        public override int SaveChanges()
        {
            AddContextCompletion();

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddContextCompletion();

            return base.SaveChangesAsync(cancellationToken);
        }

        private void AddContextCompletion()
        {
            Audit();
        }

        private void Audit()
        {
            // Get auditable.
            var addedEntries = ChangeTracker.Entries()
                .Where(e => e.Entity is IAuditable)
                .Where(e => e.State == EntityState.Added);

            var modifiedEntries = ChangeTracker.Entries()
                .Where(e => e.Entity is IAuditable)
                .Where(e => e.State == EntityState.Modified);

            foreach (var entry in addedEntries)
            {
                if (entry.Entity is IAuditable auditableEntry)
                {
                    auditableEntry.CreatedDate = DateTime.UtcNow;
                    auditableEntry.ModifiedDate = DateTime.UtcNow;
                }
            }

            foreach (var entry in modifiedEntries)
            {
                if (entry.Entity is IAuditable auditableEntry)
                {
                    auditableEntry.ModifiedDate = DateTime.UtcNow;
                }
            }
        }
        #endregion

    public DbSet<User> Users { get; set; }
    public DbSet<WorkoutProgram> WorkoutPrograms { get; set; }
    public DbSet<Workout> Workouts { get; set; }
    public DbSet<WorkoutProgramUserMapping> WorkoutProgramUserMappings { get; set; }
    public DbSet<WorkoutProgramMapping> WorkoutProgramMappings { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<WorkoutExerciseMapping> WorkoutExerciseMappings { get; set; }
}