using HiringManagementSystemProj.DbModels;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Applicant> Applicants { get; set; }
    public DbSet<HiringPerson> HiringPersons { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Application> Applications { get; set; }
    public DbSet<Company> Companies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // User - Applicant One-to-One
        modelBuilder.Entity<User>()
            .HasOne(u => u.Applicant)
            .WithOne(a => a.User)
            .HasForeignKey<Applicant>(a => a.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        // User - HiringPerson One-to-One
        modelBuilder.Entity<User>()
            .HasOne(u => u.HiringPerson)
            .WithOne(hp => hp.User)
            .HasForeignKey<HiringPerson>(hp => hp.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        // Company - HiringPerson One-to-Many
        modelBuilder.Entity<Company>()
            .HasMany(c => c.HiringPersons)
            .WithOne(hp => hp.Company)
            .HasForeignKey(hp => hp.CompanyId)
            .OnDelete(DeleteBehavior.Restrict);

        // HiringPerson - Job One-to-Many
        modelBuilder.Entity<HiringPerson>()
            .HasMany(hp => hp.JobsPosted)
            .WithOne(j => j.HiringPerson)
            .HasForeignKey(j => j.PostedBy)
            .OnDelete(DeleteBehavior.Restrict);

        // Applicant - Applications One-to-Many (NO CASCADE DELETE)
        modelBuilder.Entity<Applicant>()
            .HasMany(a => a.Applications)
            .WithOne(app => app.Applicant)
            .HasForeignKey(app => app.ApplicantId)
            .OnDelete(DeleteBehavior.NoAction);  // Prevent circular dependency

        // Job - Applications One-to-Many (NO CASCADE DELETE)
        modelBuilder.Entity<Job>()
            .HasMany(j => j.Applications)
            .WithOne(app => app.Job)
            .HasForeignKey(app => app.AppliedFor)
            .OnDelete(DeleteBehavior.NoAction);  // Prevent circular dependency

        // Application - Job Relationship
        modelBuilder.Entity<Application>()
            .HasOne(a => a.Job)
            .WithMany(j => j.Applications)
            .HasForeignKey(a => a.AppliedFor)
            .OnDelete(DeleteBehavior.NoAction);

        // Application - Applicant Relationship
        modelBuilder.Entity<Application>()
            .HasOne(a => a.Applicant)
            .WithMany(a => a.Applications)
            .HasForeignKey(a => a.ApplicantId)
            .OnDelete(DeleteBehavior.NoAction);
    }

  //  override void onmo

}
