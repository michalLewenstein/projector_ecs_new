using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class FundingType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? Code { get; set; }
}
