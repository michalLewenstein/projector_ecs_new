using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestRequiredDocument
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? IsDefForPlanning { get; set; }

    public bool? IsDefForWork { get; set; }

    public bool? IsDefForTrans { get; set; }

    public bool? IsDefForFinish { get; set; }

    public bool? IsAutoList { get; set; }

    public bool? IsDynamic { get; set; }
}
