using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class CompanyPhone
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string? Phone { get; set; }

    public bool IsDefault { get; set; }

    public bool? IsActive { get; set; }

    public virtual CompanyDetail Company { get; set; } = null!;
}
