using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class PaymentUnit
{
    public int Id { get; set; }

    public string? UnitManagerName { get; set; }

    public string? UnitDepName { get; set; }

    public string? UnitEmail { get; set; }

    public bool? IsActive { get; set; }
}
