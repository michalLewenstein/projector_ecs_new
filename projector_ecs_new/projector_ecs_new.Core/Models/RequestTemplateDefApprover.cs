using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class RequestTemplateDefApprover
{
    public int Id { get; set; }

    public int? IdRequestTemplate { get; set; }

    public int? IdApprover { get; set; }

    public virtual AuthRequestApprover? IdApproverNavigation { get; set; }

    public virtual RequestTemplate? IdRequestTemplateNavigation { get; set; }
}
