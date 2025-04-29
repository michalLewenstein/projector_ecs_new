using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ArMtlSyncLog
{
    public int Id { get; set; }

    public DateTime? SyncDatetime { get; set; }

    public int? IdUser { get; set; }

    public string? SyncAction { get; set; }

    public string? SyncResultObj { get; set; }
}
