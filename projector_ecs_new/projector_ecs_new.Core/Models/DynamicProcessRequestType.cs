using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class DynamicProcessRequestType
{
    public int Id { get; set; }

    public int? IdDynamicProcess { get; set; }

    public int? IdRequestType { get; set; }

    public int? SerialNumber { get; set; }
}
