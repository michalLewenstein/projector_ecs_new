using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestLogActivity
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? UserType { get; set; }
}
