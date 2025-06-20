using APBD_Retake.API.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_Retake.API.DAL.Context;

public class WorkshopContext : DbContext
{
    public WorkshopContext()
    {
    }

    public WorkshopContext(DbContextOptions<WorkshopContext> options) : base(options)
    {
    }
    
    public DbSet<Client> Clients { get; set; }
    public DbSet<Mechanic> Mechanics { get; set; }
    public DbSet<Visit> Visits { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Visit_Service> Visit_Services { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("Client");
        });

        modelBuilder.Entity<Mechanic>(entity =>
        {
            entity.ToTable("Mechanic");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.ToTable("Service");
        });

        modelBuilder.Entity<Visit>(entity =>
        {
            entity.ToTable("Visit");
        });

        modelBuilder.Entity<Visit_Service>(entity =>
        {
            entity.ToTable("Visit_Service");
        });
    }
}