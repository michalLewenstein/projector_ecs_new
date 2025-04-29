using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestAdditionalAuthority
{
    public int Id { get; set; }

    public int? IdAuthRequest { get; set; }

    public int? IdAuthority { get; set; }

    public string? RoleDescription { get; set; }
}
