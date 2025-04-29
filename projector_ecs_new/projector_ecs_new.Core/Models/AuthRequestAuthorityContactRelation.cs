using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestAuthorityContactRelation
{
    public int Id { get; set; }

    public int? IdAuthRequestAuthority { get; set; }

    public int? IdAuthRequestContact { get; set; }
}
