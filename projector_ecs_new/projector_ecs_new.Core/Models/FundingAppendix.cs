using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class FundingAppendix
{
    public int Id { get; set; }

    public string? Appendix { get; set; }

    public int? FundingTypeId { get; set; }
}
