using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestStage
{
    public int Id { get; set; }

    public int? IdAuthRequest { get; set; }

    public int? StageOrder { get; set; }

    public string? StageTitle { get; set; }

    public string? StageDescription { get; set; }

    public DateTime? StageActStartDate { get; set; }

    public DateTime? StageActFinishDate { get; set; }

    public bool? IsCompleted { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
