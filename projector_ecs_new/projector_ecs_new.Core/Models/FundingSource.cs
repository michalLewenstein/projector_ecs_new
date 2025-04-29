using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class FundingSource
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? IdFundingType { get; set; }
}
