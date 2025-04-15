﻿using System;
using System.Collections.Generic;

namespace ConsoleAppFirstSession.Models;

public partial class Alfa
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    
    public ICollection<User> Users { get; set; } = new List<User>();
}
