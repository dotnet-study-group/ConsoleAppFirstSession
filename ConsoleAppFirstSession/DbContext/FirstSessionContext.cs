using ConsoleAppFirstSession.Models;

namespace ConsoleAppFirstSession.DbContext;

using Microsoft.EntityFrameworkCore;

public class FirstSessionContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    
    public FirstSessionContext()
    {
        
    }
    
    public FirstSessionContext(DbContextOptions<FirstSessionContext> options) : base(options)
    {
        
    }

    /*
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=FirstSession;Integrated Security=True");
    }
    */

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(e => e.Id).HasName("PK_Users_Id");

                entity.HasIndex(e => e.UserName, "UQ_Users_UserName").IsUnique();

                entity.Property(e => e.Email).HasMaxLength(50);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(50);
                entity.Property(e => e.Password).HasMaxLength(20);

                entity.HasOne(r => r.Role).WithMany(u => u.Users)
                    .HasForeignKey(r => r.RoleId)
                    .HasConstraintName("FK_Users_Roles");
            }
        );
        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");
            entity.HasKey(e => e.Id).HasName("PK_Roles_Id");
            
            entity.HasIndex(e => e.Name, "UQ_Role_Name").IsUnique();
            
            entity.Property(e => e.Name).HasMaxLength(20);
        });
    }
}