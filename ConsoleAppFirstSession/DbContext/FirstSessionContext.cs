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
    
    public DbSet<User> Users { get; set; }
}