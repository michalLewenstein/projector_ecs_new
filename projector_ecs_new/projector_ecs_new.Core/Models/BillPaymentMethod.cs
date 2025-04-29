using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class BillPaymentMethod
{
    public int Id { get; set; }

    public int? IdBill { get; set; }

    public int? PaymentMethod { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? PaymentNum { get; set; }

    public decimal? PaymentTotal { get; set; }
}
