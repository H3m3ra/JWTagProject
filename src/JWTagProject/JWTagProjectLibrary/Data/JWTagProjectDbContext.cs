using JWTagProjectLibrary.BDO;
using JWTagProjectLibrary.Data.Converter;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace JWTagProjectLibrary.Data;

public class JWTagProjectDbContext : DbContext
{
    public DbSet<Exam> Exams { get; set; }
    public DbSet<ExamType> ExamTypes { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Tag> Tags { get; set; }

    public JWTagProjectDbContext()
    {

    }

    public JWTagProjectDbContext(DbContextOptions<JWTagProjectDbContext> options) : base(options)
    {
    
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("ConnectionString");
            optionsBuilder.UseSqlite(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exam>()
            .HasOne(e => e.Type)
            .WithMany(e => e.NavExams);
        modelBuilder.Entity<Exam>()
            .HasMany(e => e.NavExercises)
            .WithOne(e => e.Exam);
        modelBuilder.Entity<Exam>()
            .HasOne(e => e.Faculty)
            .WithMany(e => e.NavExams);

        modelBuilder.Entity<Exercise>()
            .HasMany(e => e.Tags)
            .WithMany(e => e.NavExcersises);

        modelBuilder.Entity<Tag>()
            .Property(t => t.Color)
            .HasConversion<ColorDbConverter>();
    }
}