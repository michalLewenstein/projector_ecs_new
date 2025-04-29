using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class CompanyEmail
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string? Email { get; set; }

    public bool IsDefault { get; set; }

    public bool? IsActive { get; set; }

    public virtual CompanyDetail Company { get; set; } = null!;
}
