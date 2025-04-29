using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class DynamicRequestGeneralSetting
{
    public int Id { get; set; }

    public int? IdRequestType { get; set; }

    public bool? AdminUpdate { get; set; }

    public bool? RequestLocation { get; set; }

    public bool? TrafficRegulationProcess { get; set; }

    public bool? RequestType { get; set; }

    public bool? RequestStatus { get; set; }

    public bool? ApproverStatus { get; set; }

    public bool? CertificateValidityPeriod { get; set; }

    public bool? RequiredDocuments { get; set; }

    public bool? CoordinationProtocol { get; set; }

    public bool? Msg { get; set; }

    public bool? JobDetails { get; set; }

    public bool? Documentation { get; set; }

    public bool? Contacts { get; set; }

    public bool? ConfirmationDetails { get; set; }

    public string? ProcessTerminationDocumentId { get; set; }

    public string? GenerateProcessTerminationDocument { get; set; }

    public bool? ContractorCommitment { get; set; }

    public bool? Resources { get; set; }

    public bool? ShowMmg { get; set; }

    public bool? ShowMap { get; set; }

    public bool IsDisplayInNewRequest { get; set; }
}
