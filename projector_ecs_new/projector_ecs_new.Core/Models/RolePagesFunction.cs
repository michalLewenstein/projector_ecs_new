using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class RolePagesFunction
{
    public int Id { get; set; }

    public int PageFunctionId { get; set; }

    public string Name { get; set; } = null!;

    public byte? Type { get; set; }

    public virtual ICollection<RolePageFunction> RolePageFunctions { get; } = new List<RolePageFunction>();
}
