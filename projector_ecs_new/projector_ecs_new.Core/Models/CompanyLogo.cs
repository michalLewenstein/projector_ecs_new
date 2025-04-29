using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class CompanyLogo
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    public string? Extantion { get; set; }

    public string? Align { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public bool IsDefault { get; set; }

    public bool? IsActive { get; set; }

    public virtual CompanyDetail Company { get; set; } = null!;
}
