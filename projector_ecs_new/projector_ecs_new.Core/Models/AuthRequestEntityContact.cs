using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestEntityContact
{
    public int Id { get; set; }

    public int? IdAuthRequestEntity { get; set; }

    public int? IdAuthRequestContact { get; set; }

    public int? IdAuthRequestContactType { get; set; }
}
