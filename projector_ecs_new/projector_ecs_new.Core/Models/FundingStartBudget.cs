using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class FundingStartBudget
{
    public int Id { get; set; }

    public int IdFunding { get; set; }

    public decimal StartBudget { get; set; }

    public int Year { get; set; }
}
