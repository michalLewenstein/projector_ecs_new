using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class CityStreet
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? StreetId { get; set; }

    public int? StreetNum { get; set; }

    public int? Gush { get; set; }

    public int? Helka { get; set; }
}
