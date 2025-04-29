using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ArMtlApplicationContactDetail
{
    public int Id { get; set; }

    public int? IdMtlApplication { get; set; }

    public string? ApplicationId { get; set; }

    public string? ContactId { get; set; }

    public string? Name { get; set; }

    public string? Role { get; set; }

    public string? JobTitle { get; set; }

    public string? CompanyId { get; set; }

    public string? CompanyVatNumber { get; set; }

    public string? CompanyName { get; set; }

    public string? Email { get; set; }

    public string? MobilePhone { get; set; }
}
