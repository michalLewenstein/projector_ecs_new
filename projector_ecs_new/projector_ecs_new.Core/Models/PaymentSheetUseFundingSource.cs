using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class PaymentSheetUseFundingSource
{
    public int Id { get; set; }

    public int? IdPaymentSheet { get; set; }

    public int? IdProjectFunding { get; set; }

    public decimal? Percentage { get; set; }
}
