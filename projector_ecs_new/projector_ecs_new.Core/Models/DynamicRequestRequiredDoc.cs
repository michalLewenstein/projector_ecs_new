using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class DynamicRequestRequiredDoc
{
    public int Id { get; set; }

    public int? IdDynamicRequest { get; set; }

    public int? IdRequiredDoc { get; set; }
}
