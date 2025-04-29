using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ArMtlRequestType
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public int? IdNum { get; set; }

    public string? Description { get; set; }

    public int? Env { get; set; }

    public int? EcsIdRequestType { get; set; }
}
