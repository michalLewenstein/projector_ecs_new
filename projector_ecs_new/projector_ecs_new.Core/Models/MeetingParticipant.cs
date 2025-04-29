using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class MeetingParticipant
{
    public int Id { get; set; }

    public int MeetId { get; set; }

    public string ParticipantName { get; set; } = null!;

    public string TypeName { get; set; } = null!;

    public virtual MeetingNote Meet { get; set; } = null!;
}
