using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestApproverGroupList
{
    public int Id { get; set; }

    public int IdApproverGroup { get; set; }

    public int IdApprover { get; set; }
}
