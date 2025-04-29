using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class SystemContent
{
    public int Id { get; set; }

    public string? KeyName { get; set; }

    public string? KeyTitle { get; set; }

    public string? ContentText { get; set; }

    public bool IsMessageTemplate { get; set; }
}
