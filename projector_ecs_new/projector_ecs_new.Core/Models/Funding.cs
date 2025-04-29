using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class Funding
{
    public int Id { get; set; }

    public int? TabarNumber { get; set; }

    public string? TabarName { get; set; }

    public decimal? TotalFundingHeight { get; set; }

    public decimal? TotalMoneyUsed { get; set; }

    public decimal? TotalMoneyLeft { get; set; }

    public int? IdFundingStatus { get; set; }

    public int? IdFundingSource { get; set; }

    public bool? IsApproved { get; set; }

    public string? Comments { get; set; }
}
