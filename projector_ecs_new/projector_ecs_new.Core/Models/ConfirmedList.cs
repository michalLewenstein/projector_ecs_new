using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ConfirmedList
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public int PaymentsSheetId { get; set; }

    public int? PaymentSheetOrderId { get; set; }

    public int BillNumberId { get; set; }

    public int ProjectStageId { get; set; }

    public Guid UniqueId { get; set; }

    public bool IsConfirmed { get; set; }

    public int? Userid { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public DateTime? DateSend { get; set; }

    public DateTime? DateRequest { get; set; }

    public int? SignatureOrder { get; set; }

    public string? PsNumber { get; set; }
}
