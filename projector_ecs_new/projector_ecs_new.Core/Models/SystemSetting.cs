using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class SystemSetting
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public string? Extra { get; set; }

    public bool IsImage { get; set; }
}
