using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class Project
{
    public int Id { get; set; }

    public string? OrderNumber { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? OrderName { get; set; }

    public string? OrderDepartment { get; set; }

    public string? TenderNumber { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? LocationAddress { get; set; }

    public int? LocationLat { get; set; }

    public int? LocationLong { get; set; }

    public int? IdFunding { get; set; }

    public int? IdProjectManager { get; set; }

    public int? IdProjectSupervisor { get; set; }

    public decimal? BudgetEvaluation { get; set; }

    public decimal? BudgetByFunding { get; set; }

    public decimal? BudgetFinal { get; set; }

    public DateTime? LastProjectUpdate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EstimateFinishDate { get; set; }

    public DateTime? ActingFinishDate { get; set; }

    public int? IdStatus { get; set; }

    public bool? IsImp { get; set; }

    public decimal? TotalPercentHeapByEstimation { get; set; }

    public decimal? TotalPercentHeapByImplementation { get; set; }

    public DateTime? Date1Planning { get; set; }

    public DateTime? Date2Auction { get; set; }

    public DateTime? Date3Organize { get; set; }

    public DateTime? Date4Implementation { get; set; }

    public DateTime? Date5Delivery { get; set; }

    public int? PaymentsConditionsId { get; set; }

    public decimal? PercentPerformanceGuarantee { get; set; }

    public DateTime? ExpirationDatePerformanceGuarantee { get; set; }

    public decimal? PercentBedekGuarantee { get; set; }

    public DateTime? ExpirationDateBedekGuarantee { get; set; }

    public bool IsSubProject { get; set; }

    public int? MasterProjectId { get; set; }

    public DateTime? DateCreate { get; set; }

    public int? CreatedBy { get; set; }

    public virtual ICollection<MeetingNote> MeetingNotes { get; } = new List<MeetingNote>();

    public virtual ICollection<PaymentsSheet> PaymentsSheets { get; } = new List<PaymentsSheet>();

    public virtual ICollection<ProjectDeliveryBag> ProjectDeliveryBags { get; } = new List<ProjectDeliveryBag>();
}
