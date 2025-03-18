using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppFirstSession.Models;

[Table("Role")]
public class Role
{
    public int Id { get; set; }
    
    [StringLength(20)]
    public string Name { get; set; } = null!;
    
    public List<User> Users { get; set; } = new List<User>();
}