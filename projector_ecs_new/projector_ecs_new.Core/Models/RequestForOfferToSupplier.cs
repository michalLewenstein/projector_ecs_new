using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class RequestForOfferToSupplier
{
    public int Id { get; set; }

    public int? IdRequestForOffer { get; set; }

    public int? IdSupplier { get; set; }

    public int? IdSupplierRequestStatus { get; set; }

    public bool? IsSentOffer { get; set; }

    public DateTime? SendDatetime { get; set; }

    public string? Comment { get; set; }
}
