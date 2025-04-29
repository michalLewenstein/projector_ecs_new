using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class RequestTemplateOption
{
    public int Id { get; set; }

    public int? IdRequestTemplate { get; set; }

    public string? OptionType { get; set; }

    public string? Text { get; set; }

    public string? OptionText { get; set; }
}
