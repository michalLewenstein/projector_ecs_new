using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class PaymentsSheet
{
    public int Id { get; set; }

    public int? IdProject { get; set; }

    public int? IdProjectStage { get; set; }

    public int? IdSupplier { get; set; }

    public int? IdSupplierType { get; set; }

    public string? TitleName { get; set; }

    public bool? IsFixedPrice { get; set; }

    public double? PercentPayment { get; set; }

    public decimal? PriceByEstimation { get; set; }

    public decimal? PriceByEstimationWithVat { get; set; }

    public decimal? PriceByImplementation { get; set; }

    public decimal? PriceByImplementationWithVat { get; set; }

    public int? BillsNumber { get; set; }

    public double? PercentHeapByEstimation { get; set; }

    public double? PercentHeapByImplementation { get; set; }

    public decimal? TotalPaymentApprovalByEstimation { get; set; }

    public decimal? TotalPaymentApprovalByImplementation { get; set; }

    public decimal? TotalCostAfterIncreaseByEstimation { get; set; }

    public decimal? TotalCostAfterIncreaseByImplementation { get; set; }

    public decimal? TotalReductionByEstimation { get; set; }

    public decimal? TotalReductionByImplementation { get; set; }

    public decimal? TotalPaymentPercentByEstimation { get; set; }

    public decimal? TotalPaymentPercentByImplementation { get; set; }

    public decimal? TotalPaymentWithVatByEstimation { get; set; }

    public decimal? TotalPaymentWithVatByImplementation { get; set; }

    public double? TotalPercentHeapByEstimation2 { get; set; }

    public double? TotalPercentHeapByImplementation { get; set; }

    public bool? IsRetrofitted { get; set; }

    public bool? IsImp { get; set; }

    public int? MeasureBill { get; set; }

    public bool? IsCommissionByPrecent { get; set; }

    public double? PercentCommissionPayment { get; set; }

    public decimal? PriceCompanyByEstimation { get; set; }

    public decimal? PriceCompanyByEstimationWithVat { get; set; }

    public decimal? PriceCompanyByImplementation { get; set; }

    public decimal? PriceCompanyByImplementationWithVat { get; set; }

    public double? PrecentMaam { get; set; }

    public bool? IsProjectImplementor { get; set; }

    public int? IdPsStatus { get; set; }

    public string? PsNumber { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? IdFunding { get; set; }

    public int? IdProjectManager { get; set; }

    public int? IdCurrentUserConfirm { get; set; }

    public virtual ICollection<BillPayment> BillPayments { get; } = new List<BillPayment>();

    public virtual Project? IdProjectNavigation { get; set; }

    public virtual ICollection<PaymentsSheetApproval> PaymentsSheetApprovals { get; } = new List<PaymentsSheetApproval>();
}
