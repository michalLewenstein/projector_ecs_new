using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestApproverCondition
{
    public int Id { get; set; }

    public int? IdApprover { get; set; }

    public int? IdCondition { get; set; }

    public bool? IsDefault { get; set; }
}
