using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class PsChangesLog
{
    public int Id { get; set; }

    public int? ProjectId { get; set; }

    public int? PaymentSheetId { get; set; }

    public string? UserFullName { get; set; }

    public int? UserId { get; set; }

    public DateTime? LogDate { get; set; }

    public string? Comment { get; set; }
}
