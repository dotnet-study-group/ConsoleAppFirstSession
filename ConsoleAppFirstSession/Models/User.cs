using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleAppFirstSession.Models;

[Table("Users")]
public class User
{
    public int Id { get; set; }
    
    [StringLength(100)]
    public string? FirstName { get; set; }
    
    [StringLength(100)]
    public string? LastName { get; set; }
    
    [StringLength(100)]
    public string? Email { get; set; }
    
    [StringLength(20)]
    public string Password { get; set; } = string.Empty;
    
    [StringLength(50)]
    public string UserName { get; set; } = null!;
    
    public DateTime? CreatedDate { get; set; }
    
    public DateTime? ModifiedDate { get; set; }
    
    public int RoleId { get; set; }
    
    public Role Role { get; set; } = null!;
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendFormat("Identificador {0}", Id).AppendLine();
        sb.AppendFormat("Nombre {0}", FirstName).AppendLine();
        sb.AppendFormat("Usuario {0}", UserName).AppendLine();
        sb.AppendFormat("Password {0}", Password).AppendLine();
        sb.AppendFormat("Role {0}", Role?.Name).AppendLine();
        
        return sb.ToString();
    }
}