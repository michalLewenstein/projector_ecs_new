using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestSecureLink
{
    public int Id { get; set; }

    public string? LinkType { get; set; }

    public int? IdAuthRequest { get; set; }

    public int? IdContact { get; set; }

    public int? IdApprover { get; set; }

    public int? IdEntity { get; set; }

    public int? IdUser { get; set; }

    public DateTime? SentDatetime { get; set; }

    public string? SentToEmail { get; set; }

    public DateTime? FirstOpenedDatetime { get; set; }

    public DateTime? LastOpenedDatetime { get; set; }

    public string? SecureKey { get; set; }
}
