using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class UserLog
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ActivityType { get; set; }

    public DateTime DateTime { get; set; }

    public virtual SysUser User { get; set; } = null!;
}
