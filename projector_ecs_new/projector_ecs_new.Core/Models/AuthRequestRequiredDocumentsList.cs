using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestRequiredDocumentsList
{
    public int Id { get; set; }

    public int? IdAuthRequest { get; set; }

    public string? Name { get; set; }

    public int? IdRequiredDocument { get; set; }

    public bool? IsUploaded { get; set; }

    public int? IdDocument { get; set; }

    public int? RequestedById { get; set; }

    public string? RequestedByName { get; set; }

    public int? IdArProcess { get; set; }

    public int? IdMtlDocument { get; set; }
}
