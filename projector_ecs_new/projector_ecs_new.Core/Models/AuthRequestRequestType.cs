using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestRequestType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? StatusIsActive { get; set; }

    public int? IdDynamicProcess { get; set; }
}
