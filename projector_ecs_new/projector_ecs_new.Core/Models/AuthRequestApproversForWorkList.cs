using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestApproversForWorkList
{
    public int Id { get; set; }

    public int? IdAuthRequest { get; set; }

    public int? IdAuthRequestApproverId { get; set; }

    public bool? IsAuthReqSent { get; set; }

    public int? ConfirmStatus { get; set; }

    public DateTime? SentDate { get; set; }

    public DateTime? ConfirmDate { get; set; }

    public string? Comments { get; set; }

    public bool? IsLast { get; set; }

    public int? IdOptionRequest { get; set; }

    public bool? IsTempTransApproval { get; set; }

    public string? Signature { get; set; }
}
