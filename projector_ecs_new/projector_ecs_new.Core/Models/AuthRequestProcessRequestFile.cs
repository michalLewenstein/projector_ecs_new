using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestProcessRequestFile
{
    public int Id { get; set; }

    public int? IdAuthRequestProcess { get; set; }

    public int? IdFileType { get; set; }

    public string? RequestFileDescription { get; set; }

    public DateTime? RequestDatetime { get; set; }

    public bool? IsFileUploaded { get; set; }

    public int? IdDocument { get; set; }

    public DateTime? UploadedDatetime { get; set; }
}
