using System;
using System.Collections.Generic;

namespace TestCore.Models;

public partial class Login
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }
}
