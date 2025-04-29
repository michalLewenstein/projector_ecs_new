using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestTemplateLayer
{
    public int Id { get; set; }

    public int? IdTamplate { get; set; }

    public int? IdLayer { get; set; }

    public string? LayerName { get; set; }

    public string? LayerColor { get; set; }
}
