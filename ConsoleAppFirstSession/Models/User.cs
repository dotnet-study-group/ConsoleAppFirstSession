using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppFirstSession.Models;

[Table("Users")]
public class User
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string Password { get; set; } = string.Empty;
    public string UserName { get; set; } = null!;
}