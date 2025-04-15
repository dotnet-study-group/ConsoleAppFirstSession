using System;
using System.Collections.Generic;

namespace ConsoleAppFirstSession.Models;

public partial class User
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string Password { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
    
    public int AlfaId { get; set; }
    public virtual Alfa? Alfa { get; set; }
}
