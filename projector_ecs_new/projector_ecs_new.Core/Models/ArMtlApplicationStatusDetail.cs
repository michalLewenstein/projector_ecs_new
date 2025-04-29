using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ArMtlApplicationStatusDetail
{
    public int Id { get; set; }

    public int? IdMtlApplication { get; set; }

    public string? ApplicationId { get; set; }

    public DateTime? StatusCreatedOn { get; set; }

    public string? StatusId { get; set; }

    public string? StatusName { get; set; }
}
