using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestAuthority
{
    public int Id { get; set; }

    public string? AuthorityName { get; set; }

    public string? TzHp { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public int? IdAuthorityType { get; set; }
}
