using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestEntity
{
    public int Id { get; set; }

    public string? EntityName { get; set; }

    public string? ContactPersonName { get; set; }

    public string? ContactPersonTz { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactPersonPhone { get; set; }

    public string? EntityAddress { get; set; }

    public string? EntityCode { get; set; }

    public int? IdRequestAnswere { get; set; }

    public int? IdAuthRequestAuthority { get; set; }

    public int? IdAuthRequestContact { get; set; }
}
