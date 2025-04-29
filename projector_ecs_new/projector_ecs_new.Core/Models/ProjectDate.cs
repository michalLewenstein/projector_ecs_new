using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ProjectDate
{
    public int Id { get; set; }

    public int IdProject { get; set; }

    public int IdStatus { get; set; }

    public DateTime EstDate { get; set; }
}
