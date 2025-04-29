using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestApprover
{
    public int Id { get; set; }

    public string? ApproverName { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactEmail { get; set; }

    public bool? IsLast { get; set; }

    public bool? IsLastForWork { get; set; }

    public string? AccessCode { get; set; }

    public int? IdRequestTemplate { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsExternal { get; set; }

    public bool? IncludedByDefault { get; set; }

    public bool? IncludedForWorkByDefault { get; set; }

    public int? ListOrder { get; set; }

    public int? IdAuthRequestAuthority { get; set; }

    public int? IdAuthRequestContact { get; set; }

    public bool? IncludedForFinishByDefault { get; set; }

    public bool? IsLastForFinish { get; set; }

    public bool? IsTempTransApprover { get; set; }

    public bool? IncludedForTempTransByDefault { get; set; }

    public bool? PublishToShared { get; set; }

    public int? IdCompanyApprover { get; set; }

    public virtual ICollection<RequestTemplateDefApprover> RequestTemplateDefApprovers { get; } = new List<RequestTemplateDefApprover>();
}
