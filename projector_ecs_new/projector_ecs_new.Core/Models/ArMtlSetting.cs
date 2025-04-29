using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ArMtlSetting
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? KeyName { get; set; }

    public string? Value { get; set; }

    public string? Extra { get; set; }
}
