using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class RolePageFunction
{
    public int RoleId { get; set; }

    public int PageFunctionId { get; set; }

    public bool? IsBlocked { get; set; }

    public bool? IsRead { get; set; }

    public bool? IsWrite { get; set; }

    public bool? IsReport { get; set; }

    public bool? IsSignature { get; set; }

    public virtual RolePagesFunction PageFunction { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
