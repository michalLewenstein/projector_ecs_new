using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ArMtlContact
{
    public int Id { get; set; }

    public int? EcsIdContact { get; set; }

    public string? ContactGuid { get; set; }

    public string? ContactName { get; set; }

    public string? ContactTz { get; set; }

    public string? ContactPhone { get; set; }

    public string? ContactEmail { get; set; }
}
