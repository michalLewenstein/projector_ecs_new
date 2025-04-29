using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class PaymentSheetOrder
{
    public int Id { get; set; }

    public int? IdProject { get; set; }

    public int? IdPaymentSheet { get; set; }

    public string? OrderNumber { get; set; }

    public int? IdProjectFunding { get; set; }

    public DateTime? DateKabala { get; set; }

    public DateTime? DateMesira { get; set; }

    public bool? IsApproved { get; set; }
}
