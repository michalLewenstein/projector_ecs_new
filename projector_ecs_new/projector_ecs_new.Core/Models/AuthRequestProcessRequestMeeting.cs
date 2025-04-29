using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestProcessRequestMeeting
{
    public int Id { get; set; }

    public int? IdAuthRequestProcess { get; set; }

    public string? MeetingTypeName { get; set; }

    public string? MeetingAdditionalInfo { get; set; }

    public bool? IsScheduled { get; set; }

    public DateTime? MeetingDatetime { get; set; }

    public string? MeetingLocation { get; set; }

    public bool? IsDone { get; set; }
}
