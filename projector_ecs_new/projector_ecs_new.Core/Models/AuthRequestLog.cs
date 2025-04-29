using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestLog
{
    public int Id { get; set; }

    public int? IdActivity { get; set; }

    public int? IdUser { get; set; }

    public int? IdContact { get; set; }

    public int? IdAuthRequest { get; set; }

    public DateTime? ActivityDatetime { get; set; }

    public int? IdParam1 { get; set; }

    public string? Param1Key { get; set; }

    public int? IdParam2 { get; set; }

    public string? Param2Key { get; set; }

    public string? AdditionalDescription { get; set; }
}
