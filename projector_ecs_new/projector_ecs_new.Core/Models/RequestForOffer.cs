using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class RequestForOffer
{
    public int Id { get; set; }

    public int? IdProject { get; set; }

    public int? IdUser { get; set; }

    public string? RequestTitle { get; set; }

    public DateTime? RequestToDate { get; set; }

    public string? RequestContent { get; set; }

    public int? IdRequestStatus { get; set; }

    public int? IdChoosenSupplier { get; set; }

    public string? ToSuppliersArr { get; set; }
}
