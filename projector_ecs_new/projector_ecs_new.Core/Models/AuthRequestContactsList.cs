using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestContactsList
{
    public int Id { get; set; }

    public int? IdAuthRequest { get; set; }

    public int? IdAuthRequestContact { get; set; }

    public DateTime? DatetimeJoined { get; set; }

    public string? ColorHex { get; set; }
}
