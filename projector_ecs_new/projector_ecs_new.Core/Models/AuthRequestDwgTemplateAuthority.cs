using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestDwgTemplateAuthority
{
    public int Id { get; set; }

    public int? IdDwgTemplate { get; set; }

    public int? IdAuthority { get; set; }

    public bool? IsPrimary { get; set; }
}
