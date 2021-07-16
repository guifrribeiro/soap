using Microsoft.EntityFrameworkCore;

namespace Models
{
  public class UserContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql(@"Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=soap;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<User>(entity =>
      {
        entity.ToTable("Users", "public");
        entity.Property(e => e.Id)
          .HasColumnName("Id");
        entity.Property(e => e.Name).HasColumnName("Name");
        entity.Property(e => e.Email)
          .HasColumnName("Email");
        entity.Property(e => e.Password).HasColumnName("Password");
        entity.Property(e => e.Admin).HasColumnName("Admin");
        entity.Property(e => e.Created).HasColumnName("Created");
        entity.Property(e => e.Updated).HasColumnName("Updated");
      });
    }
    
    public DbSet<User> Users { get; set; }
  }
}