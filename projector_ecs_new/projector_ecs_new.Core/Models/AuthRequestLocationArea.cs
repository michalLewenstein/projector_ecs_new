using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestLocationArea
{
    public int Id { get; set; }

    public int? IdInternal { get; set; }

    public string? Name { get; set; }

    public string? GeoBorder { get; set; }
}
