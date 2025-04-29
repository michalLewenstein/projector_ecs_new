using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ArMtlApplicationMessageDetail
{
    public int Id { get; set; }

    public int? IdMtlApplication { get; set; }

    public string? ApplicationId { get; set; }

    public string? MessageId { get; set; }

    public string? MessageCreatedById { get; set; }

    public string? MessageCreatedByName { get; set; }

    public DateTime? MessageCreatedOn { get; set; }

    public string? MessageRecipients { get; set; }

    public string? MessageDescription { get; set; }
}
