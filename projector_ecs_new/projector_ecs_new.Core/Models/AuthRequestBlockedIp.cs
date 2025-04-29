using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestBlockedIp
{
    public int Id { get; set; }

    public string? BlockedIp { get; set; }

    public DateTime? AddedDatetime { get; set; }

    public string? Reason { get; set; }

    public string? Reference { get; set; }
}
