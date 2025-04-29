using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class DynamicRequestStaticFieldsSetting
{
    public int Id { get; set; }

    public int? IdRequestType { get; set; }

    public bool? AuthorityPlanner { get; set; }

    public bool? AuthorityConstructor { get; set; }

    public bool? AuthoritySupervisor { get; set; }

    public bool? AuthorityFor { get; set; }

    public bool? AdditionalAuthorities { get; set; }

    public bool? Street { get; set; }

    public bool? PlanNumber { get; set; }

    public bool? WorkDetails { get; set; }

    public bool? WorkDescription { get; set; }

    public bool? WorkType { get; set; }

    public bool? DiggingLength { get; set; }

    public bool? DiggingDepth { get; set; }

    public bool? DiggingWidth { get; set; }

    public bool? Comments { get; set; }

    public bool? AuthorityWorkCoordinator { get; set; }

    public bool? AuthorityFinishCoordinator { get; set; }

    public bool? AuthorityPlannerIsRequired { get; set; }

    public bool? AuthorityConstructorIsRequired { get; set; }

    public bool? AuthoritySupervisorIsRequired { get; set; }

    public bool? AuthorityForIsRequired { get; set; }

    public bool? AdditionalAuthoritiesIsRequired { get; set; }

    public bool? StreetIsRequired { get; set; }

    public bool? PlanNumberIsRequired { get; set; }

    public bool? WorkDescriptionIsRequired { get; set; }

    public bool? WorkTypeIsRequired { get; set; }

    public bool? DiggingLengthIsRequired { get; set; }

    public bool? DiggingDepthIsRequired { get; set; }

    public bool? DiggingWidthIsRequired { get; set; }

    public bool? CommentsIsRequired { get; set; }

    public bool? AuthorityWorkCoordinatorIsRequired { get; set; }

    public bool? AuthorityFinishCoordinatorIsRequired { get; set; }

    public string? OptionalTitleAuthorityPlanner { get; set; }

    public string? OptionalTitleAuthorityConstructor { get; set; }

    public string? OptionalTitleAuthoritySupervisor { get; set; }

    public string? OptionalTitleAuthorityFor { get; set; }

    public string? OptionalTitleAdditionalAuthorities { get; set; }

    public string? OptionalTitleContactSet { get; set; }

    public bool? ContactSet { get; set; }

    public bool? AuthorityContactSetIsRequired { get; set; }

    public string? OptionalTitleAuthorityFinishCoordinator { get; set; }

    public string? OptionalTitleAuthorityWorkCoordinator { get; set; }

    public bool? GushAndHelka { get; set; }

    public bool? GushAndHelkaIsRequired { get; set; }

    public bool? CreatingContactAndSendingEmailForAuthorityFor { get; set; }

    public bool? CreatingContactAndSendingEmailForConstructor { get; set; }

    public bool? CreatingContactAndSendingEmailForPlanner { get; set; }

    public bool? CreatingContactAndSendingEmailForSupervisor { get; set; }

    public bool? AuthorityContactSetIsPrivate { get; set; }

    public bool? StreetIsSimpleAddress { get; set; }

    public bool? RequestOkCheckbox { get; set; }

    public string RequestOkCheckboxTitle { get; set; } = null!;

    public string RequestOkCheckboxDetails { get; set; } = null!;

    public string? OptionalTitleAddress { get; set; }

    public bool? CopyingContactSetDetailsInRequestRoll { get; set; }
}
