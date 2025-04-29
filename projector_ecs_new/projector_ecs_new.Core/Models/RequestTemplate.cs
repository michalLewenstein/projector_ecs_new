using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class RequestTemplate
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public string? CommitmentText { get; set; }

    public virtual ICollection<RequestTemplateDefApprover> RequestTemplateDefApprovers { get; } = new List<RequestTemplateDefApprover>();
}
