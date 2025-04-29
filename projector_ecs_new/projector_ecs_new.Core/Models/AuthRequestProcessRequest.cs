using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestProcessRequest
{
    public int Id { get; set; }

    public int? IdContactCreated { get; set; }

    public int? IdContactTarget { get; set; }

    public int? IdAuthRequest { get; set; }

    public int? IdAuthRequestType { get; set; }

    public int? IdAuthRequestApproverInList { get; set; }

    public string? ProcessDescription { get; set; }

    public int? IdProcessType { get; set; }

    public int? IdProcessStatus { get; set; }

    public string? StatusContactCreated { get; set; }

    public string? StatusContactTarget { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? CompletedDate { get; set; }
}
