using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestEntityForAuthority
{
    public int Id { get; set; }

    public int? IdAuthRequestEntity { get; set; }

    public int? IdAuthRequestAuthority { get; set; }
}
