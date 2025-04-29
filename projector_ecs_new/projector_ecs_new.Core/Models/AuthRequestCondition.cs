using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestCondition
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? ConditionContent { get; set; }

    public int? IdConditionSubject { get; set; }

    public string? Identifier { get; set; }

    public int? ContentType { get; set; }
}
