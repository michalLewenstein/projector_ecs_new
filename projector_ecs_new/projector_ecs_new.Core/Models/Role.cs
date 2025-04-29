using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? IsBlocked { get; set; }

    public bool? IsRead { get; set; }

    public bool? IsWrite { get; set; }

    public bool? IsReport { get; set; }

    public bool? IsSignature { get; set; }

    public bool? IsAdmin { get; set; }

    public bool? IsAuthRequestSet { get; set; }

    public bool? IsApprover { get; set; }

    public bool? IsDicManager { get; set; }

    public virtual ICollection<RolePageFunction> RolePageFunctions { get; } = new List<RolePageFunction>();

    public virtual ICollection<SysUser> SysUsers { get; } = new List<SysUser>();
}
