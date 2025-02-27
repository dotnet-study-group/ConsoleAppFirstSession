using ConsoleAppFirstSession.Models;

namespace ConsoleAppFirstSession.DbContext;

using Microsoft.EntityFrameworkCore;

public class FirstSessionContext : DbContext
{
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

    public DbSet<User> Users { get; set; }
}