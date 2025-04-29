using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class BillChangesLog
{
    public int Id { get; set; }

    public int? ProjectId { get; set; }

    public int? PaymentsSheetId { get; set; }

    public int? BillNumberId { get; set; }

    public int? ProjectStageId { get; set; }

    public string? FullName { get; set; }

    public int? SignatureOrder { get; set; }

    public string? Note { get; set; }

    public decimal? BillPrice { get; set; }

    public double? BillTotalPrecent { get; set; }

    public decimal? BillReduction { get; set; }

    public decimal? BillVat { get; set; }

    public decimal? BillTotal { get; set; }

    public decimal? BillTotalWithVat { get; set; }

    public bool? IsChanged { get; set; }

    public DateTime? LogDatetime { get; set; }

    public double? BillTotaltotalPrecent { get; set; }

    public bool? IsShowInRepAskForPaymentOnebill { get; set; }

    public DateTime? DatetimeFirstopened { get; set; }

    public string? LogTextnote { get; set; }
}
