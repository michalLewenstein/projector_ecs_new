using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class DynamicRequestContent
{
    public int Id { get; set; }

    public int? IdDynamicRequest { get; set; }

    public string? ContentKey { get; set; }

    public string? ContentTitle { get; set; }

    public string? ContentHtml { get; set; }
}
