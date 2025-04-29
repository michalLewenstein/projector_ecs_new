using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ArMtlAuthority
{
    public int Id { get; set; }

    public int? EcsIdAuthority { get; set; }

    public string? AuthorityGuid { get; set; }

    public string? AuthorityName { get; set; }

    public string? AuthorityHp { get; set; }
}
