using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class BillPayment
{
    public int Id { get; set; }

    public int? IdPaymentSheet { get; set; }

    public int? IdProject { get; set; }

    public int? BillNumber { get; set; }

    public string? TransactionAccount { get; set; }

    public bool IsFixedPrice { get; set; }

    public double? PrecentForImplementation { get; set; }

    public decimal? PriceForImplementation { get; set; }

    public bool IsImp { get; set; }

    public decimal? PaymentApprovalAmount { get; set; }

    public DateTime? BillDate { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public int? MeasureBase { get; set; }

    public int? MeasureBill { get; set; }

    public double? IncreasePrecent { get; set; }

    public decimal? CostAfterIncrease { get; set; }

    public decimal? Reduction { get; set; }

    public decimal? CostAfterReduction { get; set; }

    public double? BillVat { get; set; }

    public decimal? TotalBillPayment { get; set; }

    public string? BillPaymentCode { get; set; }

    public bool? IsRetrofitBill { get; set; }

    public decimal? MoneyPaid { get; set; }

    public decimal? MoneyPaidVat { get; set; }

    public decimal? MoneyPaidTotal { get; set; }

    public bool? IsCloseBill { get; set; }

    public bool? IsConfirmed { get; set; }

    public int? IdBillStatus { get; set; }

    public double? BillTotaltotalPrecent { get; set; }

    public bool? IsPaid { get; set; }

    public int? IdPaidType { get; set; }

    public int? PaidDate { get; set; }

    public string? PaidCheckNumber { get; set; }

    public virtual PaymentsSheet? IdPaymentSheetNavigation { get; set; }
}
