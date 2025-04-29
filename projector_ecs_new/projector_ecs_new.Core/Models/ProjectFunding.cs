using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ProjectFunding
{
    public int Id { get; set; }

    public int? IdProject { get; set; }

    public int? IdFunding { get; set; }

    public decimal? ProjectBudget { get; set; }

    public bool? IsDefault { get; set; }

    public decimal? MoneyLeft { get; set; }
}
