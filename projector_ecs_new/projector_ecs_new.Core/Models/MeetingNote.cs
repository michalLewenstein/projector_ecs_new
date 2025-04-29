using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class MeetingNote
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public string? Description { get; set; }

    public string? Subject { get; set; }

    public string? Content { get; set; }

    public string? Place { get; set; }

    public DateTime Date { get; set; }

    public DateTime DateAdd { get; set; }

    public virtual ICollection<MeetingDocument> MeetingDocuments { get; } = new List<MeetingDocument>();

    public virtual ICollection<MeetingParticipant> MeetingParticipants { get; } = new List<MeetingParticipant>();

    public virtual Project Project { get; set; } = null!;
}
