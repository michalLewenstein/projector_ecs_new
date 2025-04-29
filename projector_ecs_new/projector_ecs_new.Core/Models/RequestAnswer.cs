using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class RequestAnswer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? AnswerTxt { get; set; }

    public bool? IsDefault { get; set; }
}
