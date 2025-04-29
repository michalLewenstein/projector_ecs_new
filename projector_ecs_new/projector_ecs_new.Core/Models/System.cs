using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class System
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime? ExpDate { get; set; }
}
