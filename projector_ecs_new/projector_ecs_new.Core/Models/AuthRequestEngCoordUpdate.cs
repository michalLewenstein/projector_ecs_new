using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestEngCoordUpdate
{
    public int Id { get; set; }

    public int? IdAuthRequest { get; set; }

    public bool? IsEstDatesAndTimesUpdated { get; set; }

    public bool? IsMediaBeforeUpdated { get; set; }

    public bool? IsWorkPermitUpdated { get; set; }

    public bool? IsMediaAfterUpdated { get; set; }

    public bool? IsDeliveryProtocolUpdated { get; set; }

    public bool? IsActWorkDetailsUpdated { get; set; }

    public bool? IsWorkCompletionApprovalUpdated { get; set; }
}
