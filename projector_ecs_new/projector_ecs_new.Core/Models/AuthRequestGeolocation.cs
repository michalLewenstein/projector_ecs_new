using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestGeolocation
{
    public int Id { get; set; }

    public int? IdAuthRequest { get; set; }

    public string? GeolocationObj { get; set; }

    public string? LayerName { get; set; }

    public int? IdLayer { get; set; }

    public string? Color { get; set; }

    public int? Width { get; set; }
}
