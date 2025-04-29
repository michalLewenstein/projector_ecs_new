using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequest
{
    public int Id { get; set; }

    public int? AuthNumber { get; set; }

    public int? IdAuthRequestAuthorityFor { get; set; }

    public int? IdAuthRequestContactSet { get; set; }

    public string? FromAuthorityName { get; set; }

    public string? ToAuthorityName { get; set; }

    public string? ContactPersonName { get; set; }

    public DateTime? AuthDate { get; set; }

    public DateTime? AuthDatePlanning { get; set; }

    public DateTime? AuthDateWork { get; set; }

    public DateTime? AuthDateFinish { get; set; }

    public string? Street { get; set; }

    public int? AuthEntityId { get; set; }

    public string? WorkLengthTime { get; set; }

    public string? WorkDescription { get; set; }

    public int? AuthStatusId { get; set; }

    public string? Comments { get; set; }

    public int? IdRequestTemplate { get; set; }

    public string? FinalRequestSummery { get; set; }

    public string? FinalRequestText { get; set; }

    public DateTime? FinalRequestDatetime { get; set; }

    public string? InternalIdentifier { get; set; }

    public bool? IsFinalAppSend { get; set; }

    public bool? IsOneAppNotApp { get; set; }

    public int? RejectedBy { get; set; }

    public bool? MultipleLocations { get; set; }

    public DateTime? EstStartDate { get; set; }

    public DateTime? EstFinishDate { get; set; }

    public int? EstTotalDays { get; set; }

    public string? DatesAndTimes { get; set; }

    public DateTime? ActStartDate { get; set; }

    public DateTime? ActFinishDate { get; set; }

    public int? ActTotalDays { get; set; }

    public int? IdWorkType { get; set; }

    public string? DiggingLength { get; set; }

    public string? DiggingDepth { get; set; }

    public string? DiggingWidth { get; set; }

    public int? IdAuthorityWorkCoordinator { get; set; }

    public int? IdAuthorityPlanner { get; set; }

    public int? IdAuthorityConstructor { get; set; }

    public int? IdAuthoritySupervisor { get; set; }

    public bool? IsNightWorkAllowed { get; set; }

    public int? IdStatusBefore { get; set; }

    public string? PlanNumber { get; set; }

    public int? IdRequestType { get; set; }

    public DateTime? ApprovalPlanningDate { get; set; }

    public DateTime? ApprovalWorkDate { get; set; }

    public DateTime? ApprovalFinishDate { get; set; }

    public int? IdAuthorityFinishCoordinator { get; set; }

    public bool? IsTempTrans { get; set; }

    public int? TempTransNumber { get; set; }

    public bool? IsMtl { get; set; }

    public DateTime? PlanningExpiredDate { get; set; }

    public DateTime? WorkExpiredDate { get; set; }

    public string? ConstructorRepSignature { get; set; }

    public int? ConstructorRepIdContact { get; set; }

    public DateTime? ConstructorRepSignatureDatetime { get; set; }

    public int? TotalPlanningApproversCount { get; set; }

    public int? TotalApprovedPlanningApproversCount { get; set; }

    public int? TotalWorkApproversCount { get; set; }

    public int? TotalApprovedWorkApproversCount { get; set; }

    public int? TotalFinishApproversCount { get; set; }

    public int? TotalApprovedFinishApproversCount { get; set; }

    public bool? IsDynamic { get; set; }

    public DateTime? LastUpdate { get; set; }

    public int? IdDynamicReqType { get; set; }

    public bool? IsPublic { get; set; }

    public string? PublicFreeText { get; set; }

    public bool? ShowInCalendar { get; set; }

    public int? IdLocationArea { get; set; }

    public int? IdSystem { get; set; }

    public int? ParentArId { get; set; }

    public string? SystemName { get; set; }

    public bool? IsTrack { get; set; }

    public bool IsArchiv { get; set; }

    public bool? IsTempTransApprovedByTamrur { get; set; }

    public bool? IsTempTransConsultingCarriedOut { get; set; }

    public DateTime? TempTransTamurApprovalDate { get; set; }

    public DateTime? TempTransConsultingDate { get; set; }
}
