using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class DynamicRequestApprover
{
    public int Id { get; set; }

    public int? IdAuthReqType { get; set; }

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

    public bool? AutomaticDocumentGeneration { get; set; }

    public int? IdDocumentGeneration { get; set; }
}
