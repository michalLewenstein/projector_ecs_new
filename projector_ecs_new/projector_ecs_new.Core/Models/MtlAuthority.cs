using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class MtlAuthority
{
    public int Id { get; set; }

    public string? AuthorityName { get; set; }

    public string? DbName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastSync { get; set; }
}
