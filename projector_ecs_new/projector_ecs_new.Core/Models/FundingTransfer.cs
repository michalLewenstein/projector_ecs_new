using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class FundingTransfer
{
    public int Id { get; set; }

    public int? IdFunding { get; set; }

    public int? IdProject { get; set; }

    public decimal? TransferCost { get; set; }

    public DateTime? TransferDate { get; set; }

    public int? IdUser { get; set; }

    public int? IdSupplier { get; set; }

    public int? IdProjectStage { get; set; }
}
