using System;
using System.Collections.Generic;

namespace TestCore.Models;

public partial class UserRoleMapping
{
    public int? Id { get; set; }

    public int? UserId { get; set; }

    public int? RoleId { get; set; }
}
