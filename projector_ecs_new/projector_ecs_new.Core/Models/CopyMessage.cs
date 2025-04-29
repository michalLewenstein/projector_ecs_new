using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class CopyMessage
{
    public int Id { get; set; }

    public int IdOrderJobstart { get; set; }

    public string CopyName { get; set; } = null!;

    public byte? Orderlist { get; set; }
}
