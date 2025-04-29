using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ServiceLog
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public string? TypeOfActivity { get; set; }

    public string? AuhtorityName { get; set; }
}
