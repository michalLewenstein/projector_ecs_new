using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class DynamicRequestContact
{
    public int Id { get; set; }

    public int? IdRequestType { get; set; }

    public int? IdContact { get; set; }

    public bool? IsRequestsManager { get; set; }

    public bool? IsAuthsManager { get; set; }

    public bool? IsDistributeRequests { get; set; }
}
