using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ReportsList
{
    public int Id { get; set; }

    public string? PageName { get; set; }

    public string? Title { get; set; }

    public short? Role { get; set; }

    public bool? Active { get; set; }

    public int Order { get; set; }
}
