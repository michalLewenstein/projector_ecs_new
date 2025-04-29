using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class PaymentCondition
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public bool Active { get; set; }
}
