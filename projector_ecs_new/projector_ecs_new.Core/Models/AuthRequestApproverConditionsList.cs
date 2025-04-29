using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestApproverConditionsList
{
    public int Id { get; set; }

    public int? IdApprover { get; set; }

    public int? IdCondition { get; set; }

    public int? IdAuthRequest { get; set; }

    public int? IdApproverApprovment { get; set; }

    public string? TextType { get; set; }
}
