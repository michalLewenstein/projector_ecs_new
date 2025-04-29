using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class MeetingDocument
{
    public int Id { get; set; }

    public int? MeetId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Filename { get; set; } = null!;

    public string ContentType { get; set; } = null!;

    public int IdUser { get; set; }

    public DateTime UploadDate { get; set; }

    public virtual MeetingNote? Meet { get; set; }
}
