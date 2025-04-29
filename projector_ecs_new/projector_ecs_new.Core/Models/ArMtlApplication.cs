using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ArMtlApplication
{
    public int Id { get; set; }

    public int? EcsIdAuthRequest { get; set; }

    public string? ApplicationId { get; set; }

    public string? ApplicationNumber { get; set; }

    public string? ApplicationName { get; set; }

    public string? RequestId { get; set; }

    public string? RequestNumber { get; set; }

    public string? ProjectId { get; set; }

    public string? ProjectNumber { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectDescription { get; set; }

    public string? ProjectPlaceDescription { get; set; }

    public string? WorkingPlace { get; set; }

    public DateTime? ApplicationCreatedOn { get; set; }

    public DateTime? ApplicationModifiedOn { get; set; }

    public string? RequestTypeId { get; set; }

    public string? RequestTypeName { get; set; }

    public string? ApplicaitonInternalReferenceNumber { get; set; }

    public string? ProjectCompanyInitiateId { get; set; }

    public string? InitiativeCompanyVatNumber { get; set; }

    public string? ProjectCompanyInitiateName { get; set; }

    public string? RecepientCompanyId { get; set; }

    public string? RecipientCompanyVatNumber { get; set; }

    public string? RecepientCompanyName { get; set; }

    public string? ApplicationStatusId { get; set; }

    public string? ApplicationStatusName { get; set; }

    public string? ReasonFinishTreatment { get; set; }

    public bool? InternalApplictionIsExists { get; set; }

    public string? CancelledReason { get; set; }

    public string? ApplicationLink { get; set; }

    public string? Aoicode { get; set; }

    public DateTime? PolygonCreatedDate { get; set; }

    public string? AoigeoJsonXy { get; set; }

    public string? LatLongGeoJson { get; set; }

    public string? ApplicationCreatedByName { get; set; }

    public string? ApplicationCreatedByPhone { get; set; }

    public string? ApplicationCreatedByMail { get; set; }

    public string? ApplicationOwnerId { get; set; }

    public string? ApplicationOwnerName { get; set; }

    public string? NumMainProgramNum { get; set; }
}
