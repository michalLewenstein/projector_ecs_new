using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ArMtlApplicationTaskDetail
{
    public int Id { get; set; }

    public int? IdMtlApplication { get; set; }

    public string? ApplicationId { get; set; }

    public string? TaskId { get; set; }

    public string? TaskCreatedById { get; set; }

    public string? TaskCreatedByName { get; set; }

    public DateTime? TaskCreatedOn { get; set; }

    public string? TaskOwnerId { get; set; }

    public string? TaskOwnerName { get; set; }

    public string? TaskTitle { get; set; }

    public string? TaskStatusId { get; set; }

    public string? TaskStatusName { get; set; }
}
