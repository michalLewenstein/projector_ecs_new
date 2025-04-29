using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class PaymentsSheetApproval
{
    public int Id { get; set; }

    public int? IdPaymentSheet { get; set; }

    public int? IdProject { get; set; }

    public int? IdRole { get; set; }

    public int? IdUserApproved { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public virtual PaymentsSheet? IdPaymentSheetNavigation { get; set; }
}
