namespace ConsoleAppFirstSession.Inputs;

public class UserInput
{
    public int Id { get; set; }
    
    public string? FirstName { get; set; }
    
    public string? LastName { get; set; }
    
    public string? Email { get; set; }
    
    public string Password { get; set; } = string.Empty;
    
    public string UserName { get; set; } = null!;
    
    public DateTime? CreatedDate { get; set; }
    
    public DateTime? ModifiedDate { get; set; }
    
    public int RoleId { get; set; }
}