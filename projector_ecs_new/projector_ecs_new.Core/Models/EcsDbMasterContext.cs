using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using projector_ecs_new.Core.Dto;

namespace projector_ecs_new.Core.Models;

public partial class EcsDbMasterContext : DbContext
{
    public EcsDbMasterContext()
    {
    }

    public EcsDbMasterContext(DbContextOptions<EcsDbMasterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ArMtlApplication> ArMtlApplications { get; set; }

    public virtual DbSet<ArMtlApplicationAttachmentDetail> ArMtlApplicationAttachmentDetails { get; set; }

    public virtual DbSet<ArMtlApplicationContactDetail> ArMtlApplicationContactDetails { get; set; }

    public virtual DbSet<ArMtlApplicationMessageDetail> ArMtlApplicationMessageDetails { get; set; }

    public virtual DbSet<ArMtlApplicationStatusDetail> ArMtlApplicationStatusDetails { get; set; }

    public virtual DbSet<ArMtlApplicationTaskDetail> ArMtlApplicationTaskDetails { get; set; }

    public virtual DbSet<ArMtlAuthority> ArMtlAuthorities { get; set; }

    public virtual DbSet<ArMtlContact> ArMtlContacts { get; set; }

    public virtual DbSet<ArMtlEndRequestReasonsProd> ArMtlEndRequestReasonsProds { get; set; }

    public virtual DbSet<ArMtlRequestType> ArMtlRequestTypes { get; set; }

    public virtual DbSet<ArMtlSetting> ArMtlSettings { get; set; }

    public virtual DbSet<ArMtlSyncLog> ArMtlSyncLogs { get; set; }

    public virtual DbSet<AuthRequest> AuthRequests { get; set; }

    public virtual DbSet<AuthRequestAdditionalAuthority> AuthRequestAdditionalAuthorities { get; set; }

    public virtual DbSet<AuthRequestApprover> AuthRequestApprovers { get; set; }

    public virtual DbSet<AuthRequestApproverCondition> AuthRequestApproverConditions { get; set; }

    public virtual DbSet<AuthRequestApproverConditionsList> AuthRequestApproverConditionsLists { get; set; }

    public virtual DbSet<AuthRequestApproverGroup> AuthRequestApproverGroups { get; set; }

    public virtual DbSet<AuthRequestApproverGroupList> AuthRequestApproverGroupLists { get; set; }

    public virtual DbSet<AuthRequestApproverGroupReqDocList> AuthRequestApproverGroupReqDocLists { get; set; }

    public virtual DbSet<AuthRequestApproversForFinishList> AuthRequestApproversForFinishLists { get; set; }

    public virtual DbSet<AuthRequestApproversForWorkList> AuthRequestApproversForWorkLists { get; set; }

    public virtual DbSet<AuthRequestApproversList> AuthRequestApproversLists { get; set; }

    public virtual DbSet<AuthRequestAuthority> AuthRequestAuthorities { get; set; }

    public virtual DbSet<AuthRequestAuthorityContactRelation> AuthRequestAuthorityContactRelations { get; set; }

    public virtual DbSet<AuthRequestAuthorityType> AuthRequestAuthorityTypes { get; set; }

    public virtual DbSet<AuthRequestBlockedIp> AuthRequestBlockedIps { get; set; }

    public virtual DbSet<AuthRequestCondition> AuthRequestConditions { get; set; }

    public virtual DbSet<AuthRequestConditionSubject> AuthRequestConditionSubjects { get; set; }

    public virtual DbSet<AuthRequestContact> AuthRequestContacts { get; set; }

    public virtual DbSet<AuthRequestContactType> AuthRequestContactTypes { get; set; }

    public virtual DbSet<AuthRequestContactsList> AuthRequestContactsLists { get; set; }

    public virtual DbSet<AuthRequestDocType> AuthRequestDocTypes { get; set; }

    public virtual DbSet<AuthRequestDocumentElement> AuthRequestDocumentElements { get; set; }

    public virtual DbSet<AuthRequestDocumentTemplate> AuthRequestDocumentTemplates { get; set; }

    public virtual DbSet<AuthRequestDocumentTemplateElement> AuthRequestDocumentTemplateElements { get; set; }

    public virtual DbSet<AuthRequestDwgTemplate> AuthRequestDwgTemplates { get; set; }

    public virtual DbSet<AuthRequestDwgTemplateAuthority> AuthRequestDwgTemplateAuthorities { get; set; }

    public virtual DbSet<AuthRequestEngCoordMsg> AuthRequestEngCoordMsgs { get; set; }

    public virtual DbSet<AuthRequestEngCoordMsgType> AuthRequestEngCoordMsgTypes { get; set; }

    public virtual DbSet<AuthRequestEngCoordUpdate> AuthRequestEngCoordUpdates { get; set; }

    public virtual DbSet<AuthRequestEntity> AuthRequestEntities { get; set; }

    public virtual DbSet<AuthRequestEntityContact> AuthRequestEntityContacts { get; set; }

    public virtual DbSet<AuthRequestEntityForAuthority> AuthRequestEntityForAuthorities { get; set; }

    public virtual DbSet<AuthRequestGeolocation> AuthRequestGeolocations { get; set; }

    public virtual DbSet<AuthRequestLayer> AuthRequestLayers { get; set; }

    public virtual DbSet<AuthRequestLocationArea> AuthRequestLocationAreas { get; set; }

    public virtual DbSet<AuthRequestLog> AuthRequestLogs { get; set; }

    public virtual DbSet<AuthRequestLogActivity> AuthRequestLogActivities { get; set; }

    public virtual DbSet<AuthRequestProcessRequest> AuthRequestProcessRequests { get; set; }

    public virtual DbSet<AuthRequestProcessRequestFile> AuthRequestProcessRequestFiles { get; set; }

    public virtual DbSet<AuthRequestProcessRequestMeeting> AuthRequestProcessRequestMeetings { get; set; }

    public virtual DbSet<AuthRequestRequestType> AuthRequestRequestTypes { get; set; }

    public virtual DbSet<AuthRequestRequiredDocument> AuthRequestRequiredDocuments { get; set; }

    public virtual DbSet<AuthRequestRequiredDocumentsList> AuthRequestRequiredDocumentsLists { get; set; }

    public virtual DbSet<AuthRequestResource> AuthRequestResources { get; set; }

    public virtual DbSet<AuthRequestResourceCoordination> AuthRequestResourceCoordinations { get; set; }

    public virtual DbSet<AuthRequestSecureLink> AuthRequestSecureLinks { get; set; }

    public virtual DbSet<AuthRequestStage> AuthRequestStages { get; set; }

    public virtual DbSet<AuthRequestTemplateLayer> AuthRequestTemplateLayers { get; set; }

    public virtual DbSet<AuthRequestWorkType> AuthRequestWorkTypes { get; set; }

    public virtual DbSet<AuthorizedSignature> AuthorizedSignatures { get; set; }

    public virtual DbSet<BillChangesLog> BillChangesLogs { get; set; }

    public virtual DbSet<BillPayment> BillPayments { get; set; }

    public virtual DbSet<BillPaymentMethod> BillPaymentMethods { get; set; }

    public virtual DbSet<BillStatus> BillStatuses { get; set; }

    public virtual DbSet<CityStreet> CityStreets { get; set; }

    public virtual DbSet<CompanyDetail> CompanyDetails { get; set; }

    public virtual DbSet<CompanyEmail> CompanyEmails { get; set; }

    public virtual DbSet<CompanyFax> CompanyFaxes { get; set; }

    public virtual DbSet<CompanyLogo> CompanyLogos { get; set; }

    public virtual DbSet<CompanyPhone> CompanyPhones { get; set; }

    public virtual DbSet<ConfirmedList> ConfirmedLists { get; set; }

    public virtual DbSet<ContactDetail> ContactDetails { get; set; }

    public virtual DbSet<CopyMessage> CopyMessages { get; set; }

    public virtual DbSet<DeliveryBag> DeliveryBags { get; set; }

    public virtual DbSet<DirectoryInfo> DirectoryInfos { get; set; }

    public virtual DbSet<DocSubject> DocSubjects { get; set; }

    public virtual DbSet<DocType> DocTypes { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<DynamicProcess> DynamicProcesses { get; set; }

    public virtual DbSet<DynamicProcessRequestType> DynamicProcessRequestTypes { get; set; }

    public virtual DbSet<DynamicRequestApprover> DynamicRequestApprovers { get; set; }

    public virtual DbSet<DynamicRequestApproversList> DynamicRequestApproversLists { get; set; }

    public virtual DbSet<DynamicRequestContact> DynamicRequestContacts { get; set; }

    public virtual DbSet<DynamicRequestContent> DynamicRequestContents { get; set; }

    public virtual DbSet<DynamicRequestDomain> DynamicRequestDomains { get; set; }

    public virtual DbSet<DynamicRequestDynamicFieldsSetting> DynamicRequestDynamicFieldsSettings { get; set; }

    public virtual DbSet<DynamicRequestDynamicFieldsValue> DynamicRequestDynamicFieldsValues { get; set; }

    public virtual DbSet<DynamicRequestGeneralSetting> DynamicRequestGeneralSettings { get; set; }

    public virtual DbSet<DynamicRequestRequiredDoc> DynamicRequestRequiredDocs { get; set; }

    public virtual DbSet<DynamicRequestStaticFieldsSetting> DynamicRequestStaticFieldsSettings { get; set; }

    public virtual DbSet<Funding> Fundings { get; set; }

    public virtual DbSet<FundingAppendix> FundingAppendices { get; set; }

    public virtual DbSet<FundingSource> FundingSources { get; set; }

    public virtual DbSet<FundingStartBudget> FundingStartBudgets { get; set; }

    public virtual DbSet<FundingStatus> FundingStatuses { get; set; }

    public virtual DbSet<FundingTransfer> FundingTransfers { get; set; }

    public virtual DbSet<FundingType> FundingTypes { get; set; }

    public virtual DbSet<LocationsDatum> LocationsData { get; set; }

    public virtual DbSet<MeetingDocument> MeetingDocuments { get; set; }

    public virtual DbSet<MeetingNote> MeetingNotes { get; set; }

    public virtual DbSet<MeetingParticipant> MeetingParticipants { get; set; }

    public virtual DbSet<MtlAuthority> MtlAuthorities { get; set; }

    public virtual DbSet<OrderJobstart> OrderJobstarts { get; set; }

    public virtual DbSet<PaymentCondition> PaymentConditions { get; set; }

    public virtual DbSet<PaymentSheetOrder> PaymentSheetOrders { get; set; }

    public virtual DbSet<PaymentSheetUseFundingSource> PaymentSheetUseFundingSources { get; set; }

    public virtual DbSet<PaymentUnit> PaymentUnits { get; set; }

    public virtual DbSet<PaymentsSheet> PaymentsSheets { get; set; }

    public virtual DbSet<PaymentsSheetApproval> PaymentsSheetApprovals { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectDate> ProjectDates { get; set; }

    public virtual DbSet<ProjectDeliveryBag> ProjectDeliveryBags { get; set; }

    public virtual DbSet<ProjectFunding> ProjectFundings { get; set; }

    public virtual DbSet<ProjectStage> ProjectStages { get; set; }

    public virtual DbSet<ProjectStatus> ProjectStatuses { get; set; }

    public virtual DbSet<PsChangesLog> PsChangesLogs { get; set; }

    public virtual DbSet<ReportsList> ReportsLists { get; set; }

    public virtual DbSet<RequestAnswer> RequestAnswers { get; set; }

    public virtual DbSet<RequestForOffer> RequestForOffers { get; set; }

    public virtual DbSet<RequestForOfferToSupplier> RequestForOfferToSuppliers { get; set; }

    public virtual DbSet<RequestTemplate> RequestTemplates { get; set; }

    public virtual DbSet<RequestTemplateDefApprover> RequestTemplateDefApprovers { get; set; }

    public virtual DbSet<RequestTemplateOption> RequestTemplateOptions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolePageFunction> RolePageFunctions { get; set; }

    public virtual DbSet<RolePagesFunction> RolePagesFunctions { get; set; }

    public virtual DbSet<ServiceLog> ServiceLogs { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SupplierType> SupplierTypes { get; set; }

    public virtual DbSet<SysUser> SysUsers { get; set; }

    public virtual DbSet<System> Systems { get; set; }

    public virtual DbSet<SystemContent> SystemContents { get; set; }

    public virtual DbSet<SystemSetting> SystemSettings { get; set; }

    public virtual DbSet<TypeActivityList> TypeActivityLists { get; set; }

    public virtual DbSet<UserLog> UserLogs { get; set; }
  

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-TBRB539;DataBase=ECS_DB_Master;TrustServerCertificate=True;Trusted_Connection=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ArMtlApplication>(entity =>
        {
            entity.ToTable("ar_mtl_application");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aoicode)
                .HasMaxLength(150)
                .HasColumnName("AOICode");
            entity.Property(e => e.AoigeoJsonXy)
                .HasMaxLength(250)
                .HasColumnName("AOIGeoJsonXY");
            entity.Property(e => e.ApplicaitonInternalReferenceNumber).HasMaxLength(50);
            entity.Property(e => e.ApplicationCreatedByMail).HasMaxLength(150);
            entity.Property(e => e.ApplicationCreatedByName).HasMaxLength(150);
            entity.Property(e => e.ApplicationCreatedByPhone).HasMaxLength(150);
            entity.Property(e => e.ApplicationCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ApplicationId).HasMaxLength(150);
            entity.Property(e => e.ApplicationLink).HasMaxLength(450);
            entity.Property(e => e.ApplicationModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ApplicationName).HasMaxLength(250);
            entity.Property(e => e.ApplicationNumber).HasMaxLength(50);
            entity.Property(e => e.ApplicationOwnerId)
                .HasMaxLength(150)
                .HasColumnName("ApplicationOwnerID");
            entity.Property(e => e.ApplicationOwnerName).HasMaxLength(150);
            entity.Property(e => e.ApplicationStatusId).HasMaxLength(150);
            entity.Property(e => e.ApplicationStatusName).HasMaxLength(150);
            entity.Property(e => e.CancelledReason).HasMaxLength(150);
            entity.Property(e => e.EcsIdAuthRequest).HasColumnName("ecs_id_auth_request");
            entity.Property(e => e.InitiativeCompanyVatNumber).HasMaxLength(50);
            entity.Property(e => e.LatLongGeoJson).HasColumnName("LAT_LONG_GeoJson");
            entity.Property(e => e.NumMainProgramNum).HasMaxLength(250);
            entity.Property(e => e.PolygonCreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ProjectCompanyInitiateId).HasMaxLength(150);
            entity.Property(e => e.ProjectCompanyInitiateName).HasMaxLength(150);
            entity.Property(e => e.ProjectDescription).HasMaxLength(450);
            entity.Property(e => e.ProjectId).HasMaxLength(150);
            entity.Property(e => e.ProjectName).HasMaxLength(250);
            entity.Property(e => e.ProjectNumber).HasMaxLength(50);
            entity.Property(e => e.ProjectPlaceDescription).HasMaxLength(150);
            entity.Property(e => e.ReasonFinishTreatment).HasMaxLength(150);
            entity.Property(e => e.RecepientCompanyId).HasMaxLength(150);
            entity.Property(e => e.RecepientCompanyName).HasMaxLength(150);
            entity.Property(e => e.RecipientCompanyVatNumber).HasMaxLength(50);
            entity.Property(e => e.RequestId).HasMaxLength(150);
            entity.Property(e => e.RequestNumber).HasMaxLength(50);
            entity.Property(e => e.RequestTypeId).HasMaxLength(150);
            entity.Property(e => e.RequestTypeName).HasMaxLength(150);
            entity.Property(e => e.WorkingPlace).IsUnicode(false);
        });

        modelBuilder.Entity<ArMtlApplicationAttachmentDetail>(entity =>
        {
            entity.ToTable("ar_mtl_application_attachment_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationId).HasMaxLength(150);
            entity.Property(e => e.ApplicationNumber).HasMaxLength(50);
            entity.Property(e => e.AttachedDocumentsToRequestFile).HasMaxLength(450);
            entity.Property(e => e.AttachmentLink).HasMaxLength(450);
            entity.Property(e => e.DocCreatedBy).HasMaxLength(150);
            entity.Property(e => e.DocCreatedById).HasMaxLength(150);
            entity.Property(e => e.DocCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DocSize).HasMaxLength(50);
            entity.Property(e => e.DocType).HasMaxLength(150);
            entity.Property(e => e.DocUploadBy).HasMaxLength(150);
            entity.Property(e => e.DocUploadById).HasMaxLength(150);
            entity.Property(e => e.DocumentCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DocumentId).HasMaxLength(150);
            entity.Property(e => e.DocumentType).HasMaxLength(50);
            entity.Property(e => e.EcsIdDocument).HasColumnName("ecs_id_document");
            entity.Property(e => e.FileName).HasMaxLength(350);
            entity.Property(e => e.IdMtlApplication).HasColumnName("id_mtl_application");
        });

        modelBuilder.Entity<ArMtlApplicationContactDetail>(entity =>
        {
            entity.ToTable("ar_mtl_application_contact_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationId).HasMaxLength(150);
            entity.Property(e => e.CompanyId).HasMaxLength(150);
            entity.Property(e => e.CompanyName).HasMaxLength(150);
            entity.Property(e => e.CompanyVatNumber).HasMaxLength(50);
            entity.Property(e => e.ContactId).HasMaxLength(150);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.IdMtlApplication).HasColumnName("id_mtl_application");
            entity.Property(e => e.JobTitle).HasMaxLength(150);
            entity.Property(e => e.MobilePhone).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Role).HasMaxLength(50);
        });

        modelBuilder.Entity<ArMtlApplicationMessageDetail>(entity =>
        {
            entity.ToTable("ar_mtl_application_message_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationId).HasMaxLength(50);
            entity.Property(e => e.IdMtlApplication).HasColumnName("id_mtl_application");
            entity.Property(e => e.MessageCreatedById).HasMaxLength(150);
            entity.Property(e => e.MessageCreatedByName).HasMaxLength(50);
            entity.Property(e => e.MessageCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.MessageId).HasMaxLength(150);
            entity.Property(e => e.MessageRecipients).HasMaxLength(250);
        });

        modelBuilder.Entity<ArMtlApplicationStatusDetail>(entity =>
        {
            entity.ToTable("ar_mtl_application_status_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationId).HasMaxLength(150);
            entity.Property(e => e.IdMtlApplication).HasColumnName("id_mtl_application");
            entity.Property(e => e.StatusCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StatusId).HasMaxLength(150);
            entity.Property(e => e.StatusName).HasMaxLength(150);
        });

        modelBuilder.Entity<ArMtlApplicationTaskDetail>(entity =>
        {
            entity.ToTable("ar_mtl_application_task_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicationId).HasMaxLength(150);
            entity.Property(e => e.IdMtlApplication).HasColumnName("id_mtl_application");
            entity.Property(e => e.TaskCreatedById).HasMaxLength(150);
            entity.Property(e => e.TaskCreatedByName).HasMaxLength(50);
            entity.Property(e => e.TaskCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.TaskId).HasMaxLength(150);
            entity.Property(e => e.TaskOwnerId).HasMaxLength(150);
            entity.Property(e => e.TaskOwnerName).HasMaxLength(50);
            entity.Property(e => e.TaskStatusId).HasMaxLength(150);
            entity.Property(e => e.TaskStatusName).HasMaxLength(50);
            entity.Property(e => e.TaskTitle).HasMaxLength(350);
        });

        modelBuilder.Entity<ArMtlAuthority>(entity =>
        {
            entity.ToTable("ar_mtl_authority");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthorityGuid)
                .HasMaxLength(150)
                .HasColumnName("authority_guid");
            entity.Property(e => e.AuthorityHp)
                .HasMaxLength(50)
                .HasColumnName("authority_hp");
            entity.Property(e => e.AuthorityName)
                .HasMaxLength(250)
                .HasColumnName("authority_name");
            entity.Property(e => e.EcsIdAuthority).HasColumnName("ecs_id_authority");
        });

        modelBuilder.Entity<ArMtlContact>(entity =>
        {
            entity.ToTable("ar_mtl_contact");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(150)
                .HasColumnName("contact_email");
            entity.Property(e => e.ContactGuid)
                .HasMaxLength(150)
                .HasColumnName("contact_guid");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .HasColumnName("contact_name");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(50)
                .HasColumnName("contact_phone");
            entity.Property(e => e.ContactTz)
                .HasMaxLength(50)
                .HasColumnName("contact_tz");
            entity.Property(e => e.EcsIdContact).HasColumnName("ecs_id_contact");
        });

        modelBuilder.Entity<ArMtlEndRequestReasonsProd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ar_mtl_end_request_reasons_prod$");

            entity.Property(e => e.CloseReasonDesc)
                .HasMaxLength(255)
                .HasColumnName("close_reason_desc");
            entity.Property(e => e.EcsId).HasColumnName("ecs_id");
            entity.Property(e => e.Guid)
                .HasMaxLength(255)
                .HasColumnName("guid");
            entity.Property(e => e.IdCloseReason).HasColumnName("id_close_reason");
            entity.Property(e => e.IdRequestType).HasColumnName("id_request_type");
            entity.Property(e => e.RequestTypeDesc)
                .HasMaxLength(255)
                .HasColumnName("request_type_desc");
        });

        modelBuilder.Entity<ArMtlRequestType>(entity =>
        {
            entity.ToTable("ar_mtl_request_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.EcsIdRequestType).HasColumnName("ecs_id_request_type");
            entity.Property(e => e.Env).HasColumnName("env");
            entity.Property(e => e.Guid)
                .HasMaxLength(250)
                .HasColumnName("guid");
            entity.Property(e => e.IdNum).HasColumnName("id_num");
        });

        modelBuilder.Entity<ArMtlSetting>(entity =>
        {
            entity.ToTable("ar_mtl_setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Extra)
                .HasMaxLength(150)
                .HasColumnName("extra");
            entity.Property(e => e.KeyName)
                .HasMaxLength(150)
                .HasColumnName("key_name");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<ArMtlSyncLog>(entity =>
        {
            entity.ToTable("ar_mtl_sync_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.SyncAction)
                .HasMaxLength(50)
                .HasColumnName("sync_action");
            entity.Property(e => e.SyncDatetime)
                .HasColumnType("datetime")
                .HasColumnName("sync_datetime");
            entity.Property(e => e.SyncResultObj)
                .HasMaxLength(350)
                .HasColumnName("sync_result_obj");
        });

        modelBuilder.Entity<AuthRequest>(entity =>
        {
            entity.ToTable("auth_request");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActFinishDate)
                .HasColumnType("date")
                .HasColumnName("act_finish_date");
            entity.Property(e => e.ActStartDate)
                .HasColumnType("date")
                .HasColumnName("act_start_date");
            entity.Property(e => e.ActTotalDays).HasColumnName("act_total_days");
            entity.Property(e => e.ApprovalFinishDate)
                .HasColumnType("datetime")
                .HasColumnName("approval_finish_date");
            entity.Property(e => e.ApprovalPlanningDate)
                .HasColumnType("datetime")
                .HasColumnName("approval_planning_date");
            entity.Property(e => e.ApprovalWorkDate)
                .HasColumnType("datetime")
                .HasColumnName("approval_work_date");
            entity.Property(e => e.AuthDate)
                .HasColumnType("datetime")
                .HasColumnName("auth_date");
            entity.Property(e => e.AuthDateFinish)
                .HasColumnType("datetime")
                .HasColumnName("auth_date_finish");
            entity.Property(e => e.AuthDatePlanning)
                .HasColumnType("datetime")
                .HasColumnName("auth_date_planning");
            entity.Property(e => e.AuthDateWork)
                .HasColumnType("datetime")
                .HasColumnName("auth_date_work");
            entity.Property(e => e.AuthEntityId).HasColumnName("auth_entity_id");
            entity.Property(e => e.AuthNumber).HasColumnName("auth_number");
            entity.Property(e => e.AuthStatusId).HasColumnName("auth_status_id");
            entity.Property(e => e.Comments)
                .HasColumnType("text")
                .HasColumnName("comments");
            entity.Property(e => e.ConstructorRepIdContact).HasColumnName("constructor_rep_id_contact");
            entity.Property(e => e.ConstructorRepSignature)
                .HasColumnType("text")
                .HasColumnName("constructor_rep_signature");
            entity.Property(e => e.ConstructorRepSignatureDatetime)
                .HasColumnType("datetime")
                .HasColumnName("constructor_rep_signature_datetime");
            entity.Property(e => e.ContactPersonName)
                .HasMaxLength(150)
                .HasColumnName("contact_person_name");
            entity.Property(e => e.DatesAndTimes).HasColumnName("dates_and_times");
            entity.Property(e => e.DiggingDepth)
                .HasMaxLength(50)
                .HasColumnName("digging_depth");
            entity.Property(e => e.DiggingLength)
                .HasMaxLength(50)
                .HasColumnName("digging_length");
            entity.Property(e => e.DiggingWidth)
                .HasMaxLength(50)
                .HasColumnName("digging_width");
            entity.Property(e => e.EstFinishDate)
                .HasColumnType("date")
                .HasColumnName("est_finish_date");
            entity.Property(e => e.EstStartDate)
                .HasColumnType("date")
                .HasColumnName("est_start_date");
            entity.Property(e => e.EstTotalDays).HasColumnName("est_total_days");
            entity.Property(e => e.FinalRequestDatetime).HasColumnName("final_request_datetime");
            entity.Property(e => e.FinalRequestSummery)
                .HasMaxLength(300)
                .HasColumnName("final_request_summery");
            entity.Property(e => e.FinalRequestText).HasColumnName("final_request_text");
            entity.Property(e => e.FromAuthorityName)
                .HasMaxLength(150)
                .HasColumnName("from_authority_name");
            entity.Property(e => e.IdAuthRequestAuthorityFor).HasColumnName("id_auth_request_authority_for");
            entity.Property(e => e.IdAuthRequestContactSet).HasColumnName("id_auth_request_contact_set");
            entity.Property(e => e.IdAuthorityConstructor).HasColumnName("id_authority_constructor");
            entity.Property(e => e.IdAuthorityFinishCoordinator).HasColumnName("id_authority_finish_coordinator");
            entity.Property(e => e.IdAuthorityPlanner).HasColumnName("id_authority_planner");
            entity.Property(e => e.IdAuthoritySupervisor).HasColumnName("id_authority_supervisor");
            entity.Property(e => e.IdAuthorityWorkCoordinator).HasColumnName("id_authority_work_coordinator");
            entity.Property(e => e.IdDynamicReqType)
                .HasDefaultValueSql("((0))")
                .HasColumnName("id_dynamic_req_type");
            entity.Property(e => e.IdLocationArea).HasColumnName("id_location_area");
            entity.Property(e => e.IdRequestTemplate).HasColumnName("id_request_template");
            entity.Property(e => e.IdRequestType).HasColumnName("id_request_type");
            entity.Property(e => e.IdStatusBefore).HasColumnName("id_status_before");
            entity.Property(e => e.IdSystem).HasColumnName("id_system");
            entity.Property(e => e.IdWorkType).HasColumnName("id_work_type");
            entity.Property(e => e.InternalIdentifier)
                .HasMaxLength(50)
                .HasColumnName("internal_identifier");
            entity.Property(e => e.IsArchiv).HasColumnName("is_archiv");
            entity.Property(e => e.IsDynamic).HasColumnName("is_dynamic");
            entity.Property(e => e.IsFinalAppSend).HasColumnName("is_final_app_send");
            entity.Property(e => e.IsMtl).HasColumnName("is_mtl");
            entity.Property(e => e.IsNightWorkAllowed).HasColumnName("is_night_work_allowed");
            entity.Property(e => e.IsOneAppNotApp).HasColumnName("is_one_app_not_app");
            entity.Property(e => e.IsPublic)
                .HasDefaultValueSql("((0))")
                .HasColumnName("is_public");
            entity.Property(e => e.IsTempTrans).HasColumnName("is_temp_trans");
            entity.Property(e => e.IsTempTransApprovedByTamrur)
                .HasDefaultValueSql("((0))")
                .HasColumnName("is_temp_trans_approved_by_tamrur");
            entity.Property(e => e.IsTempTransConsultingCarriedOut)
                .HasDefaultValueSql("((0))")
                .HasColumnName("is_temp_trans_consulting_carried_out");
            entity.Property(e => e.IsTrack).HasColumnName("isTrack");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("last_update");
            entity.Property(e => e.MultipleLocations).HasColumnName("multiple_locations");
            entity.Property(e => e.ParentArId).HasColumnName("parent_ar_id");
            entity.Property(e => e.PlanNumber).HasColumnName("plan_number");
            entity.Property(e => e.PlanningExpiredDate)
                .HasColumnType("datetime")
                .HasColumnName("planning_expired_date");
            entity.Property(e => e.PublicFreeText)
                .HasColumnType("text")
                .HasColumnName("public_free_text");
            entity.Property(e => e.RejectedBy).HasColumnName("rejected_by");
            entity.Property(e => e.ShowInCalendar)
                .HasDefaultValueSql("((0))")
                .HasColumnName("show_in_calendar");
            entity.Property(e => e.Street).HasColumnName("street");
            entity.Property(e => e.SystemName)
                .HasMaxLength(150)
                .HasColumnName("system_name");
            entity.Property(e => e.TempTransConsultingDate)
                .HasColumnType("date")
                .HasColumnName("temp_trans_consulting_date");
            entity.Property(e => e.TempTransNumber).HasColumnName("temp_trans_number");
            entity.Property(e => e.TempTransTamurApprovalDate)
                .HasColumnType("date")
                .HasColumnName("temp_trans_tamur_approval_date");
            entity.Property(e => e.ToAuthorityName)
                .HasMaxLength(150)
                .HasColumnName("to_authority_name");
            entity.Property(e => e.TotalApprovedFinishApproversCount).HasColumnName("total_approved_finish_approvers_count");
            entity.Property(e => e.TotalApprovedPlanningApproversCount).HasColumnName("total_approved_planning_approvers_count");
            entity.Property(e => e.TotalApprovedWorkApproversCount).HasColumnName("total_approved_work_approvers_count");
            entity.Property(e => e.TotalFinishApproversCount).HasColumnName("total_finish_approvers_count");
            entity.Property(e => e.TotalPlanningApproversCount).HasColumnName("total_planning_approvers_count");
            entity.Property(e => e.TotalWorkApproversCount).HasColumnName("total_work_approvers_count");
            entity.Property(e => e.WorkDescription).HasColumnName("work_description");
            entity.Property(e => e.WorkExpiredDate)
                .HasColumnType("datetime")
                .HasColumnName("work_expired_date");
            entity.Property(e => e.WorkLengthTime)
                .HasMaxLength(50)
                .HasColumnName("work_length_time");
        });

        modelBuilder.Entity<AuthRequestAdditionalAuthority>(entity =>
        {
            entity.ToTable("auth_request_additional_authorities");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdAuthority).HasColumnName("id_authority");
            entity.Property(e => e.RoleDescription)
                .HasMaxLength(150)
                .HasColumnName("role_description");
        });

        modelBuilder.Entity<AuthRequestApprover>(entity =>
        {
            entity.ToTable("auth_request_approvers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccessCode)
                .HasMaxLength(50)
                .HasColumnName("access_code");
            entity.Property(e => e.ApproverName)
                .HasMaxLength(150)
                .HasColumnName("approver_name");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(50)
                .HasColumnName("contact_email");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(50)
                .HasColumnName("contact_person");
            entity.Property(e => e.IdAuthRequestAuthority).HasColumnName("id_auth_request_authority");
            entity.Property(e => e.IdAuthRequestContact).HasColumnName("id_auth_request_contact");
            entity.Property(e => e.IdCompanyApprover).HasColumnName("id_company_approver");
            entity.Property(e => e.IdRequestTemplate).HasColumnName("id_request_template");
            entity.Property(e => e.IncludedByDefault).HasColumnName("included_by_default");
            entity.Property(e => e.IncludedForFinishByDefault).HasColumnName("included_for_finish_by_default");
            entity.Property(e => e.IncludedForTempTransByDefault).HasColumnName("included_for_temp_trans_by_default");
            entity.Property(e => e.IncludedForWorkByDefault).HasColumnName("included_for_work_by_default");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsExternal).HasColumnName("is_external");
            entity.Property(e => e.IsLast).HasColumnName("is_last");
            entity.Property(e => e.IsLastForFinish).HasColumnName("is_last_for_finish");
            entity.Property(e => e.IsLastForWork).HasColumnName("is_last_for_work");
            entity.Property(e => e.IsTempTransApprover).HasColumnName("is_temp_trans_approver");
            entity.Property(e => e.ListOrder).HasColumnName("list_order");
            entity.Property(e => e.PublishToShared)
                .HasDefaultValueSql("((0))")
                .HasColumnName("publish_to_shared");
        });

        modelBuilder.Entity<AuthRequestApproverCondition>(entity =>
        {
            entity.ToTable("auth_request_approver_conditions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdApprover).HasColumnName("id_approver");
            entity.Property(e => e.IdCondition).HasColumnName("id_condition");
            entity.Property(e => e.IsDefault)
                .HasDefaultValueSql("((0))")
                .HasColumnName("is_default");
        });

        modelBuilder.Entity<AuthRequestApproverConditionsList>(entity =>
        {
            entity.ToTable("auth_request_approver_conditions_list");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdApprover).HasColumnName("id_approver");
            entity.Property(e => e.IdApproverApprovment).HasColumnName("id_approver_approvment");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdCondition).HasColumnName("id_condition");
            entity.Property(e => e.TextType)
                .HasMaxLength(50)
                .HasColumnName("text_type");
        });

        modelBuilder.Entity<AuthRequestApproverGroup>(entity =>
        {
            entity.ToTable("auth_request_approver_group");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthRequestApproverGroupList>(entity =>
        {
            entity.ToTable("auth_request_approver_group_list");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdApprover).HasColumnName("id_approver");
            entity.Property(e => e.IdApproverGroup).HasColumnName("id_approver_group");
        });

        modelBuilder.Entity<AuthRequestApproverGroupReqDocList>(entity =>
        {
            entity.ToTable("auth_request_approver_group_req_doc_list");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdApproverGroup).HasColumnName("id_approver_group");
            entity.Property(e => e.IdRequiredDocument).HasColumnName("id_required_document");
        });

        modelBuilder.Entity<AuthRequestApproversForFinishList>(entity =>
        {
            entity.ToTable("auth_request_approvers_for_finish_list");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.ConfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("confirm_date");
            entity.Property(e => e.ConfirmStatus).HasColumnName("confirm_status");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdAuthRequestApproverId).HasColumnName("id_auth_request_approver_id");
            entity.Property(e => e.IdOptionRequest).HasColumnName("id_option_request");
            entity.Property(e => e.IsAuthReqSent).HasColumnName("is_auth_req_sent");
            entity.Property(e => e.IsLast).HasColumnName("is_last");
            entity.Property(e => e.SentDate)
                .HasColumnType("datetime")
                .HasColumnName("sent_date");
            entity.Property(e => e.Signature)
                .HasColumnType("text")
                .HasColumnName("signature");
        });

        modelBuilder.Entity<AuthRequestApproversForWorkList>(entity =>
        {
            entity.ToTable("auth_request_approvers_for_work_list");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.ConfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("confirm_date");
            entity.Property(e => e.ConfirmStatus).HasColumnName("confirm_status");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdAuthRequestApproverId).HasColumnName("id_auth_request_approver_id");
            entity.Property(e => e.IdOptionRequest).HasColumnName("id_option_request");
            entity.Property(e => e.IsAuthReqSent).HasColumnName("is_auth_req_sent");
            entity.Property(e => e.IsLast).HasColumnName("is_last");
            entity.Property(e => e.IsTempTransApproval).HasColumnName("is_temp_trans_approval");
            entity.Property(e => e.SentDate)
                .HasColumnType("datetime")
                .HasColumnName("sent_date");
            entity.Property(e => e.Signature)
                .HasColumnType("text")
                .HasColumnName("signature");
        });

        modelBuilder.Entity<AuthRequestApproversList>(entity =>
        {
            entity.ToTable("auth_request_approvers_list");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.ConfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("confirm_date");
            entity.Property(e => e.ConfirmStatus).HasColumnName("confirm_status");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdAuthRequestApproverId).HasColumnName("id_auth_request_approver_id");
            entity.Property(e => e.IdOptionRequest).HasColumnName("id_option_request");
            entity.Property(e => e.IsAuthReqSent).HasColumnName("is_auth_req_sent");
            entity.Property(e => e.IsLast).HasColumnName("is_last");
            entity.Property(e => e.SentDate)
                .HasColumnType("datetime")
                .HasColumnName("sent_date");
            entity.Property(e => e.Signature)
                .HasColumnType("text")
                .HasColumnName("signature");
        });

        modelBuilder.Entity<AuthRequestAuthority>(entity =>
        {
            entity.ToTable("auth_request_authority");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .HasColumnName("address");
            entity.Property(e => e.AuthorityName)
                .HasMaxLength(150)
                .HasColumnName("authority_name");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.IdAuthorityType).HasColumnName("id_authority_type");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.TzHp)
                .HasMaxLength(15)
                .HasColumnName("tz_hp");
        });

        modelBuilder.Entity<AuthRequestAuthorityContactRelation>(entity =>
        {
            entity.ToTable("auth_request_authority_contact_relation");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAuthRequestAuthority).HasColumnName("id_auth_request_authority");
            entity.Property(e => e.IdAuthRequestContact).HasColumnName("id_auth_request_contact");
        });

        modelBuilder.Entity<AuthRequestAuthorityType>(entity =>
        {
            entity.ToTable("auth_request_authority_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthRequestBlockedIp>(entity =>
        {
            entity.ToTable("auth_request_blocked_ips");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("added_datetime");
            entity.Property(e => e.BlockedIp)
                .HasMaxLength(250)
                .HasColumnName("blocked_ip");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reference).HasColumnName("reference");
        });

        modelBuilder.Entity<AuthRequestCondition>(entity =>
        {
            entity.ToTable("auth_request_conditions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConditionContent).HasColumnName("condition_content");
            entity.Property(e => e.ContentType).HasColumnName("content_type");
            entity.Property(e => e.IdConditionSubject).HasColumnName("id_condition_subject");
            entity.Property(e => e.Identifier)
                .HasMaxLength(15)
                .HasColumnName("identifier");
            entity.Property(e => e.Title)
                .HasMaxLength(500)
                .HasColumnName("title");
        });

        modelBuilder.Entity<AuthRequestConditionSubject>(entity =>
        {
            entity.ToTable("auth_request_condition_subject");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthRequestContact>(entity =>
        {
            entity.ToTable("auth_request_contact");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .HasColumnName("address");
            entity.Property(e => e.AppearsOnNewsDistributionList)
                .HasDefaultValueSql("((0))")
                .HasColumnName("appears_on_news_distribution_list");
            entity.Property(e => e.CodeAuth)
                .HasMaxLength(50)
                .HasColumnName("code_auth");
            entity.Property(e => e.CodeKey)
                .HasMaxLength(50)
                .HasColumnName("code_key");
            entity.Property(e => e.DefaultIdAuthority).HasColumnName("default_id_authority");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.ExpExpDate)
                .HasColumnType("datetime")
                .HasColumnName("exp_exp_date");
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .HasColumnName("fullname");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_active");
            entity.Property(e => e.IsApproved)
                .HasDefaultValueSql("((0))")
                .HasColumnName("is_approved");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.SettingsObj).HasColumnName("settings_obj");
            entity.Property(e => e.Signature)
                .HasColumnType("text")
                .HasColumnName("signature");
            entity.Property(e => e.TzHp)
                .HasMaxLength(50)
                .HasColumnName("tz_hp");
        });

        modelBuilder.Entity<AuthRequestContactType>(entity =>
        {
            entity.ToTable("auth_request_contact_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthRequestContactsList>(entity =>
        {
            entity.ToTable("auth_request_contacts_list");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ColorHex)
                .HasMaxLength(10)
                .HasColumnName("color_hex");
            entity.Property(e => e.DatetimeJoined)
                .HasColumnType("datetime")
                .HasColumnName("datetime_joined");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdAuthRequestContact).HasColumnName("id_auth_request_contact");
        });

        modelBuilder.Entity<AuthRequestDocType>(entity =>
        {
            entity.ToTable("auth_request_doc_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthRequestDocumentElement>(entity =>
        {
            entity.ToTable("auth_request_document_element");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
        });

        modelBuilder.Entity<AuthRequestDocumentTemplate>(entity =>
        {
            entity.ToTable("auth_request_document_template");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("created_datetime");
            entity.Property(e => e.IdDupFrom).HasColumnName("id_dup_from");
            entity.Property(e => e.IdUserCreated).HasColumnName("id_user_created");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthRequestDocumentTemplateElement>(entity =>
        {
            entity.ToTable("auth_request_document_template_element");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.IdDocumentElement).HasColumnName("id_document_element");
            entity.Property(e => e.IdDocumentTemplate).HasColumnName("id_document_template");
            entity.Property(e => e.IdParent).HasColumnName("id_parent");
            entity.Property(e => e.OrderInTemplate).HasColumnName("order_in_template");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<AuthRequestDwgTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__auth_req__3213E83F400CCA48");

            entity.ToTable("auth_request_dwg_template");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<AuthRequestDwgTemplateAuthority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__auth_req__3213E83F2D33C426");

            entity.ToTable("auth_request_dwg_template_authority");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAuthority).HasColumnName("id_authority");
            entity.Property(e => e.IdDwgTemplate).HasColumnName("id_dwg_template");
            entity.Property(e => e.IsPrimary).HasColumnName("is_primary");
        });

        modelBuilder.Entity<AuthRequestEngCoordMsg>(entity =>
        {
            entity.ToTable("auth_request_eng_coord_msg");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("created_datetime");
            entity.Property(e => e.IdArProcessRequest).HasColumnName("id_ar_process_request");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdMsgStatus).HasColumnName("id_msg_status");
            entity.Property(e => e.IdMsgType).HasColumnName("id_msg_type");
            entity.Property(e => e.IdParent).HasColumnName("id_parent");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.MetaKeys)
                .HasMaxLength(150)
                .HasColumnName("meta_keys");
            entity.Property(e => e.MsgContent).HasColumnName("msg_content");
            entity.Property(e => e.UserAuthorityName)
                .HasMaxLength(150)
                .HasColumnName("user_authority_name");
            entity.Property(e => e.UserFullname)
                .HasMaxLength(150)
                .HasColumnName("user_fullname");
            entity.Property(e => e.UserType)
                .HasMaxLength(50)
                .HasColumnName("user_type");
        });

        modelBuilder.Entity<AuthRequestEngCoordMsgType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("auth_request_eng_coord_msg_type");

            entity.Property(e => e.Description)
                .HasMaxLength(450)
                .HasColumnName("description");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthRequestEngCoordUpdate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_auth_request_coordination_protocol_params");

            entity.ToTable("auth_request_eng_coord_updates");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IsActWorkDetailsUpdated).HasColumnName("is_act_work_details_updated");
            entity.Property(e => e.IsDeliveryProtocolUpdated).HasColumnName("is_delivery_protocol_updated");
            entity.Property(e => e.IsEstDatesAndTimesUpdated)
                .HasDefaultValueSql("((0))")
                .HasColumnName("is_est_dates_and_times_updated");
            entity.Property(e => e.IsMediaAfterUpdated).HasColumnName("is_media_after_updated");
            entity.Property(e => e.IsMediaBeforeUpdated).HasColumnName("is_media_before_updated");
            entity.Property(e => e.IsWorkCompletionApprovalUpdated).HasColumnName("is_work_completion_approval_updated");
            entity.Property(e => e.IsWorkPermitUpdated).HasColumnName("is_work_permit_updated");
        });

        modelBuilder.Entity<AuthRequestEntity>(entity =>
        {
            entity.ToTable("auth_request_entities");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(150)
                .HasColumnName("contact_email");
            entity.Property(e => e.ContactPersonName)
                .HasMaxLength(100)
                .HasColumnName("contact_person_name");
            entity.Property(e => e.ContactPersonPhone)
                .HasMaxLength(20)
                .HasColumnName("contact_person_phone");
            entity.Property(e => e.ContactPersonTz)
                .HasMaxLength(50)
                .HasColumnName("contact_person_tz");
            entity.Property(e => e.EntityAddress)
                .HasMaxLength(150)
                .HasColumnName("entity_address");
            entity.Property(e => e.EntityCode)
                .HasMaxLength(10)
                .HasColumnName("entity_code");
            entity.Property(e => e.EntityName)
                .HasMaxLength(150)
                .HasColumnName("entity_name");
            entity.Property(e => e.IdAuthRequestAuthority).HasColumnName("id_auth_request_authority");
            entity.Property(e => e.IdAuthRequestContact).HasColumnName("id_auth_request_contact");
            entity.Property(e => e.IdRequestAnswere).HasColumnName("id_request_answere");
        });

        modelBuilder.Entity<AuthRequestEntityContact>(entity =>
        {
            entity.ToTable("auth_request_entity_contact");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAuthRequestContact).HasColumnName("id_auth_request_contact");
            entity.Property(e => e.IdAuthRequestContactType).HasColumnName("id_auth_request_contact_type");
            entity.Property(e => e.IdAuthRequestEntity).HasColumnName("id_auth_request_entity");
        });

        modelBuilder.Entity<AuthRequestEntityForAuthority>(entity =>
        {
            entity.ToTable("auth_request_entity_for_authorities");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAuthRequestAuthority).HasColumnName("id_auth_request_authority");
            entity.Property(e => e.IdAuthRequestEntity).HasColumnName("id_auth_request_entity");
        });

        modelBuilder.Entity<AuthRequestGeolocation>(entity =>
        {
            entity.ToTable("auth_request_geolocation");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .HasColumnName("color");
            entity.Property(e => e.GeolocationObj).HasColumnName("geolocation_obj");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdLayer).HasColumnName("id_layer");
            entity.Property(e => e.LayerName)
                .IsUnicode(false)
                .HasColumnName("layer_name");
            entity.Property(e => e.Width).HasColumnName("width");
        });

        modelBuilder.Entity<AuthRequestLayer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__auth_req__3213E83FA991EB67");

            entity.ToTable("auth_request_layer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .HasColumnName("color");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<AuthRequestLocationArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__auth_req__3213E83F53ABCF41");

            entity.ToTable("auth_request_location_area");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GeoBorder)
                .HasColumnType("text")
                .HasColumnName("geo_border");
            entity.Property(e => e.IdInternal).HasColumnName("id_internal");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthRequestLog>(entity =>
        {
            entity.ToTable("auth_request_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityDatetime)
                .HasColumnType("datetime")
                .HasColumnName("activity_datetime");
            entity.Property(e => e.AdditionalDescription)
                .HasMaxLength(250)
                .HasColumnName("additional_description");
            entity.Property(e => e.IdActivity).HasColumnName("id_activity");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdContact).HasColumnName("id_contact");
            entity.Property(e => e.IdParam1).HasColumnName("id_param1");
            entity.Property(e => e.IdParam2).HasColumnName("id_param2");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Param1Key)
                .HasMaxLength(50)
                .HasColumnName("param1_key");
            entity.Property(e => e.Param2Key)
                .HasMaxLength(50)
                .HasColumnName("param2_key");
        });

        modelBuilder.Entity<AuthRequestLogActivity>(entity =>
        {
            entity.ToTable("auth_request_log_activity");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.UserType)
                .HasMaxLength(15)
                .HasColumnName("user_type");
        });

        modelBuilder.Entity<AuthRequestProcessRequest>(entity =>
        {
            entity.ToTable("auth_request_process_request");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompletedDate)
                .HasColumnType("datetime")
                .HasColumnName("completed_date");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdAuthRequestApproverInList).HasColumnName("id_auth_request_approver_in_list");
            entity.Property(e => e.IdAuthRequestType).HasColumnName("id_auth_request_type");
            entity.Property(e => e.IdContactCreated).HasColumnName("id_contact_created");
            entity.Property(e => e.IdContactTarget).HasColumnName("id_contact_target");
            entity.Property(e => e.IdProcessStatus).HasColumnName("id_process_status");
            entity.Property(e => e.IdProcessType).HasColumnName("id_process_type");
            entity.Property(e => e.ProcessDescription).HasColumnName("process_description");
            entity.Property(e => e.StatusContactCreated)
                .HasMaxLength(150)
                .HasColumnName("status_contact_created");
            entity.Property(e => e.StatusContactTarget)
                .HasMaxLength(150)
                .HasColumnName("status_contact_target");
        });

        modelBuilder.Entity<AuthRequestProcessRequestFile>(entity =>
        {
            entity.ToTable("auth_request_process_request_files");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAuthRequestProcess).HasColumnName("id_auth_request_process");
            entity.Property(e => e.IdDocument).HasColumnName("id_document");
            entity.Property(e => e.IdFileType).HasColumnName("id_file_type");
            entity.Property(e => e.IsFileUploaded).HasColumnName("is_file_uploaded");
            entity.Property(e => e.RequestDatetime)
                .HasColumnType("datetime")
                .HasColumnName("request_datetime");
            entity.Property(e => e.RequestFileDescription)
                .HasMaxLength(250)
                .HasColumnName("request_file_description");
            entity.Property(e => e.UploadedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("uploaded_datetime");
        });

        modelBuilder.Entity<AuthRequestProcessRequestMeeting>(entity =>
        {
            entity.ToTable("auth_request_process_request_meeting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAuthRequestProcess).HasColumnName("id_auth_request_process");
            entity.Property(e => e.IsDone).HasColumnName("is_done");
            entity.Property(e => e.IsScheduled).HasColumnName("is_scheduled");
            entity.Property(e => e.MeetingAdditionalInfo)
                .HasMaxLength(250)
                .HasColumnName("meeting_additional_info");
            entity.Property(e => e.MeetingDatetime)
                .HasColumnType("datetime")
                .HasColumnName("meeting_datetime");
            entity.Property(e => e.MeetingLocation)
                .HasMaxLength(250)
                .HasColumnName("meeting_location");
            entity.Property(e => e.MeetingTypeName)
                .HasMaxLength(50)
                .HasColumnName("meeting_type_name");
        });

        modelBuilder.Entity<AuthRequestRequestType>(entity =>
        {
            entity.ToTable("auth_request_request_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdDynamicProcess).HasColumnName("id_dynamic_process");
            entity.Property(e => e.Name)
                .HasMaxLength(350)
                .HasColumnName("name");
            entity.Property(e => e.StatusIsActive).HasColumnName("status_is_active");
        });

        modelBuilder.Entity<AuthRequestRequiredDocument>(entity =>
        {
            entity.ToTable("auth_request_required_documents");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsAutoList).HasColumnName("is_auto_list");
            entity.Property(e => e.IsDefForFinish).HasColumnName("is_def_for_finish");
            entity.Property(e => e.IsDefForPlanning).HasColumnName("is_def_for_planning");
            entity.Property(e => e.IsDefForTrans).HasColumnName("is_def_for_trans");
            entity.Property(e => e.IsDefForWork).HasColumnName("is_def_for_work");
            entity.Property(e => e.IsDynamic)
                .HasDefaultValueSql("((0))")
                .HasColumnName("is_dynamic");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthRequestRequiredDocumentsList>(entity =>
        {
            entity.ToTable("auth_request_required_documents_list");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdArProcess).HasColumnName("id_ar_process");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdDocument).HasColumnName("id_document");
            entity.Property(e => e.IdMtlDocument).HasColumnName("id_mtl_document");
            entity.Property(e => e.IdRequiredDocument).HasColumnName("id_required_document");
            entity.Property(e => e.IsUploaded).HasColumnName("is_uploaded");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.RequestedById).HasColumnName("requested_by_id");
            entity.Property(e => e.RequestedByName)
                .HasMaxLength(50)
                .HasColumnName("requested_by_name");
        });

        modelBuilder.Entity<AuthRequestResource>(entity =>
        {
            entity.ToTable("auth_request_resource");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comments)
                .HasColumnType("text")
                .HasColumnName("comments");
            entity.Property(e => e.Description)
                .HasMaxLength(350)
                .HasColumnName("description");
            entity.Property(e => e.Geometrics).HasColumnName("geometrics");
            entity.Property(e => e.IdParentResource).HasColumnName("id_parent_resource");
            entity.Property(e => e.IdResourceStatus).HasColumnName("id_resource_status");
            entity.Property(e => e.IdResourceSubType).HasColumnName("id_resource_sub_type");
            entity.Property(e => e.IdResourceType).HasColumnName("id_resource_type");
            entity.Property(e => e.IdSizeType).HasColumnName("id_size_type");
            entity.Property(e => e.Instructions)
                .HasMaxLength(350)
                .HasColumnName("instructions");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.MaxNoiseLevel).HasColumnName("max_noise_level");
            entity.Property(e => e.MaxPeople).HasColumnName("max_people");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
            entity.Property(e => e.NormalPeople).HasColumnName("normal_people");
            entity.Property(e => e.SizeValue).HasColumnName("size_value");
        });

        modelBuilder.Entity<AuthRequestResourceCoordination>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__auth_req__3213E83F9C40FF10");

            entity.ToTable("auth_request_resource_coordination");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DailyRecurring).HasColumnName("daily_recurring");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("from_date");
            entity.Property(e => e.FromHour).HasColumnName("from_hour");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdResource).HasColumnName("id_resource");
            entity.Property(e => e.IsRecurring).HasColumnName("is_recurring");
            entity.Property(e => e.MonthlyRecurring).HasColumnName("monthly_recurring");
            entity.Property(e => e.ParticipantsNum).HasColumnName("participants_num");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("to_date");
            entity.Property(e => e.ToHour).HasColumnName("to_hour");
            entity.Property(e => e.WeeklyRecurring).HasColumnName("weekly_recurring");
        });

        modelBuilder.Entity<AuthRequestSecureLink>(entity =>
        {
            entity.ToTable("auth_request_secure_link");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstOpenedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("first_opened_datetime");
            entity.Property(e => e.IdApprover).HasColumnName("id_approver");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdContact).HasColumnName("id_contact");
            entity.Property(e => e.IdEntity).HasColumnName("id_entity");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.LastOpenedDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_opened_datetime");
            entity.Property(e => e.LinkType)
                .HasMaxLength(25)
                .HasColumnName("link_type");
            entity.Property(e => e.SecureKey)
                .IsUnicode(false)
                .HasColumnName("secure_key");
            entity.Property(e => e.SentDatetime)
                .HasColumnType("datetime")
                .HasColumnName("sent_datetime");
            entity.Property(e => e.SentToEmail)
                .HasMaxLength(150)
                .HasColumnName("sent_to_email");
        });

        modelBuilder.Entity<AuthRequestStage>(entity =>
        {
            entity.ToTable("auth_request_stages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approved_date");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IsApproved).HasColumnName("is_approved");
            entity.Property(e => e.IsCompleted).HasColumnName("is_completed");
            entity.Property(e => e.StageActFinishDate)
                .HasColumnType("datetime")
                .HasColumnName("stage_act_finish_date");
            entity.Property(e => e.StageActStartDate)
                .HasColumnType("datetime")
                .HasColumnName("stage_act_start_date");
            entity.Property(e => e.StageDescription).HasColumnName("stage_description");
            entity.Property(e => e.StageOrder).HasColumnName("stage_order");
            entity.Property(e => e.StageTitle)
                .HasMaxLength(350)
                .HasColumnName("stage_title");
        });

        modelBuilder.Entity<AuthRequestTemplateLayer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__auth_req__3213E83F47C6ABBB");

            entity.ToTable("auth_request_template_layers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdLayer).HasColumnName("id_layer");
            entity.Property(e => e.IdTamplate).HasColumnName("id_tamplate");
            entity.Property(e => e.LayerColor).HasColumnName("layer_color");
            entity.Property(e => e.LayerName).HasColumnName("layer_name");
        });

        modelBuilder.Entity<AuthRequestWorkType>(entity =>
        {
            entity.ToTable("auth_request_work_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(350)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthorizedSignature>(entity =>
        {
            entity.ToTable("authorized_signature");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.SignatureOrder).HasColumnName("signature_order");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<BillChangesLog>(entity =>
        {
            entity.ToTable("bill_changes_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BillNumberId).HasColumnName("bill_number_id");
            entity.Property(e => e.BillPrice)
                .HasColumnType("money")
                .HasColumnName("bill_price");
            entity.Property(e => e.BillReduction)
                .HasColumnType("money")
                .HasColumnName("bill_reduction");
            entity.Property(e => e.BillTotal)
                .HasColumnType("money")
                .HasColumnName("bill_total");
            entity.Property(e => e.BillTotalPrecent).HasColumnName("bill_total_precent");
            entity.Property(e => e.BillTotalWithVat)
                .HasColumnType("money")
                .HasColumnName("bill_total_with_vat");
            entity.Property(e => e.BillTotaltotalPrecent).HasColumnName("bill_totaltotal_precent");
            entity.Property(e => e.BillVat)
                .HasColumnType("money")
                .HasColumnName("bill_vat");
            entity.Property(e => e.DatetimeFirstopened)
                .HasColumnType("datetime")
                .HasColumnName("datetime_firstopened");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .HasColumnName("full_name");
            entity.Property(e => e.IsChanged).HasColumnName("is_changed");
            entity.Property(e => e.IsShowInRepAskForPaymentOnebill).HasColumnName("is_showInRep_AskForPayment_Onebill");
            entity.Property(e => e.LogDatetime)
                .HasColumnType("datetime")
                .HasColumnName("log_datetime");
            entity.Property(e => e.LogTextnote)
                .HasMaxLength(150)
                .HasColumnName("log_textnote");
            entity.Property(e => e.Note)
                .HasMaxLength(300)
                .HasColumnName("note");
            entity.Property(e => e.PaymentsSheetId).HasColumnName("payments_sheet_id");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.ProjectStageId).HasColumnName("project_stage_id");
            entity.Property(e => e.SignatureOrder).HasColumnName("signature_order");
        });

        modelBuilder.Entity<BillPayment>(entity =>
        {
            entity.ToTable("bill_payment");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BillDate)
                .HasColumnType("date")
                .HasColumnName("bill_date");
            entity.Property(e => e.BillNumber).HasColumnName("bill_number");
            entity.Property(e => e.BillPaymentCode)
                .HasMaxLength(50)
                .HasColumnName("bill_payment_code");
            entity.Property(e => e.BillTotaltotalPrecent).HasColumnName("bill_totaltotal_precent");
            entity.Property(e => e.BillVat).HasColumnName("bill_vat");
            entity.Property(e => e.CostAfterIncrease)
                .HasColumnType("money")
                .HasColumnName("cost_after_increase");
            entity.Property(e => e.CostAfterReduction)
                .HasColumnType("money")
                .HasColumnName("cost_after_reduction");
            entity.Property(e => e.IdBillStatus).HasColumnName("id_bill_status");
            entity.Property(e => e.IdPaidType).HasColumnName("id_paid_type");
            entity.Property(e => e.IdPaymentSheet).HasColumnName("id_payment_sheet");
            entity.Property(e => e.IdProject).HasColumnName("id_project");
            entity.Property(e => e.IncreasePrecent).HasColumnName("increase_precent");
            entity.Property(e => e.InvoiceDate)
                .HasColumnType("date")
                .HasColumnName("invoice_date");
            entity.Property(e => e.IsCloseBill).HasColumnName("is_close_bill");
            entity.Property(e => e.IsConfirmed).HasColumnName("is_confirmed");
            entity.Property(e => e.IsFixedPrice).HasColumnName("is_fixed_price");
            entity.Property(e => e.IsImp).HasColumnName("is_imp");
            entity.Property(e => e.IsPaid).HasColumnName("is_paid");
            entity.Property(e => e.IsRetrofitBill).HasColumnName("is_retrofit_bill");
            entity.Property(e => e.MeasureBase).HasColumnName("measure_base");
            entity.Property(e => e.MeasureBill).HasColumnName("measure_bill");
            entity.Property(e => e.MoneyPaid)
                .HasColumnType("money")
                .HasColumnName("money_paid");
            entity.Property(e => e.MoneyPaidTotal)
                .HasColumnType("money")
                .HasColumnName("money_paid_total");
            entity.Property(e => e.MoneyPaidVat)
                .HasColumnType("money")
                .HasColumnName("money_paid_vat");
            entity.Property(e => e.PaidCheckNumber)
                .HasMaxLength(20)
                .HasColumnName("paid_check_number");
            entity.Property(e => e.PaidDate).HasColumnName("paid_date");
            entity.Property(e => e.PaymentApprovalAmount)
                .HasColumnType("money")
                .HasColumnName("payment_approval_amount");
            entity.Property(e => e.PrecentForImplementation).HasColumnName("precent_for_implementation");
            entity.Property(e => e.PriceForImplementation)
                .HasColumnType("money")
                .HasColumnName("price_for_implementation");
            entity.Property(e => e.Reduction)
                .HasColumnType("money")
                .HasColumnName("reduction");
            entity.Property(e => e.TotalBillPayment)
                .HasColumnType("money")
                .HasColumnName("total_bill_payment");
            entity.Property(e => e.TransactionAccount)
                .HasMaxLength(25)
                .HasColumnName("Transaction_Account");

            entity.HasOne(d => d.IdPaymentSheetNavigation).WithMany(p => p.BillPayments)
                .HasForeignKey(d => d.IdPaymentSheet)
                .HasConstraintName("FK_bill_payment_payments_sheet");
        });

        modelBuilder.Entity<BillPaymentMethod>(entity =>
        {
            entity.ToTable("bill_payment_method");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdBill).HasColumnName("id_bill");
            entity.Property(e => e.PaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("payment_date");
            entity.Property(e => e.PaymentMethod).HasColumnName("payment_method");
            entity.Property(e => e.PaymentNum)
                .HasMaxLength(50)
                .HasColumnName("payment_num");
            entity.Property(e => e.PaymentTotal)
                .HasColumnType("money")
                .HasColumnName("payment_total");
        });

        modelBuilder.Entity<BillStatus>(entity =>
        {
            entity.ToTable("bill_status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BillStatus1)
                .HasMaxLength(150)
                .HasColumnName("bill_status");
            entity.Property(e => e.OrderView).HasColumnName("order_view");
        });

        modelBuilder.Entity<CityStreet>(entity =>
        {
            entity.ToTable("city_street");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Gush).HasColumnName("gush");
            entity.Property(e => e.Helka).HasColumnName("helka");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.StreetId)
                .HasMaxLength(50)
                .HasColumnName("street_id");
            entity.Property(e => e.StreetNum).HasColumnName("street_num");
        });

        modelBuilder.Entity<CompanyDetail>(entity =>
        {
            entity.ToTable("company_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApartmentNumber)
                .HasMaxLength(20)
                .HasColumnName("apartment_number");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.FontFamily)
                .HasMaxLength(50)
                .HasColumnName("font_family");
            entity.Property(e => e.FontSize).HasColumnName("font_size");
            entity.Property(e => e.FontWeight).HasColumnName("font_weight");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .HasColumnName("number");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasColumnName("street");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(10)
                .HasColumnName("zip_code");
        });

        modelBuilder.Entity<CompanyEmail>(entity =>
        {
            entity.ToTable("company_email");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_active");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyEmails)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_company_email_company_details");
        });

        modelBuilder.Entity<CompanyFax>(entity =>
        {
            entity.ToTable("company_fax");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .HasColumnName("fax");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_active");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyFaxes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_company_fax_company_details");
        });

        modelBuilder.Entity<CompanyLogo>(entity =>
        {
            entity.ToTable("company_logo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Align)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("align");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.Extantion)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("extantion");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_active");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .HasColumnName("url");
            entity.Property(e => e.Width).HasColumnName("width");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyLogos)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_company_logo_company_details");
        });

        modelBuilder.Entity<CompanyPhone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Table_1");

            entity.ToTable("company_phone");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_active");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyPhones)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_company_phone_company_details");
        });

        modelBuilder.Entity<ConfirmedList>(entity =>
        {
            entity.ToTable("confirmed_list");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BillNumberId).HasColumnName("bill_number_id");
            entity.Property(e => e.DateRequest)
                .HasColumnType("datetime")
                .HasColumnName("date_request");
            entity.Property(e => e.DateSend)
                .HasColumnType("datetime")
                .HasColumnName("date_send");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .HasColumnName("full_name");
            entity.Property(e => e.IsConfirmed).HasColumnName("is_confirmed");
            entity.Property(e => e.PaymentSheetOrderId).HasColumnName("payment_sheet_order_id");
            entity.Property(e => e.PaymentsSheetId).HasColumnName("payments_sheet_id");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.ProjectStageId).HasColumnName("project_stage_id");
            entity.Property(e => e.PsNumber)
                .HasMaxLength(20)
                .HasColumnName("ps_number");
            entity.Property(e => e.SignatureOrder).HasColumnName("signature_order");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("unique_id");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<ContactDetail>(entity =>
        {
            entity.ToTable("contact_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cellphone1)
                .HasMaxLength(50)
                .HasColumnName("cellphone1");
            entity.Property(e => e.Cellphone2)
                .HasMaxLength(50)
                .HasColumnName("cellphone2");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .HasColumnName("fax");
            entity.Property(e => e.Fulladdress)
                .HasMaxLength(250)
                .HasColumnName("fulladdress");
            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Phone1)
                .HasMaxLength(50)
                .HasColumnName("phone1");
            entity.Property(e => e.Phone2)
                .HasMaxLength(50)
                .HasColumnName("phone2");
        });

        modelBuilder.Entity<CopyMessage>(entity =>
        {
            entity.ToTable("copy_messages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CopyName)
                .HasMaxLength(50)
                .HasColumnName("copy_name");
            entity.Property(e => e.IdOrderJobstart).HasColumnName("id_order_jobstart");
            entity.Property(e => e.Orderlist).HasColumnName("orderlist");
        });

        modelBuilder.Entity<DeliveryBag>(entity =>
        {
            entity.ToTable("delivery_bag");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("isActive");
            entity.Property(e => e.IsForAllProject)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("isForAllProject");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DirectoryInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__director__3213E83FAF5ACB18");

            entity.ToTable("directory_info");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("create_date");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.RequestId).HasColumnName("request_id");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK__directory__paren__72E607DB");
        });

        modelBuilder.Entity<DocSubject>(entity =>
        {
            entity.ToTable("doc_subject");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DocType>(entity =>
        {
            entity.ToTable("doc_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.ToTable("document");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(50)
                .HasColumnName("content_type");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DirectoryInfoId).HasColumnName("directory_info_id");
            entity.Property(e => e.Filename)
                .HasMaxLength(150)
                .HasColumnName("filename");
            entity.Property(e => e.ForTempTransApproval).HasColumnName("for_temp_trans_approval");
            entity.Property(e => e.IdApprover).HasColumnName("id_approver");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdAuthRequestCoordMsg).HasColumnName("id_auth_request_coord_msg");
            entity.Property(e => e.IdAuthRequestDocType).HasColumnName("id_auth_request_doc_type");
            entity.Property(e => e.IdDocType).HasColumnName("id_doc_type");
            entity.Property(e => e.IdLayer).HasColumnName("id_layer");
            entity.Property(e => e.IdProject).HasColumnName("id_project");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.IsCompilation).HasColumnName("is_compilation");
            entity.Property(e => e.IsPublic)
                .HasDefaultValueSql("((0))")
                .HasColumnName("is_public");
            entity.Property(e => e.IsVisible).HasColumnName("is_visible");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.TypeApprover)
                .HasMaxLength(250)
                .HasColumnName("type_approver");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("upload_date");

            entity.HasOne(d => d.DirectoryInfo).WithMany(p => p.Documents)
                .HasForeignKey(d => d.DirectoryInfoId)
                .HasConstraintName("FK__document__direct__73DA2C14");
        });

        modelBuilder.Entity<DynamicProcess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dynamic___3213E83FDA07FA9D");

            entity.ToTable("dynamic_process");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DomainId).HasColumnName("domain_id");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DynamicProcessRequestType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dynamic___3213E83FDED50B74");

            entity.ToTable("dynamic_process_request_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdDynamicProcess).HasColumnName("id_dynamic_process");
            entity.Property(e => e.IdRequestType).HasColumnName("id_request_type");
            entity.Property(e => e.SerialNumber).HasColumnName("serial_number");
        });

        modelBuilder.Entity<DynamicRequestApprover>(entity =>
        {
            entity.ToTable("dynamic_request_approvers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccessCode)
                .HasMaxLength(50)
                .HasColumnName("access_code");
            entity.Property(e => e.AutomaticDocumentGeneration).HasColumnName("automatic_document_generation");
            entity.Property(e => e.IdAuthReqType).HasColumnName("id_auth_req_type");
            entity.Property(e => e.IdAuthRequestAuthority).HasColumnName("id_auth_request_authority");
            entity.Property(e => e.IdAuthRequestContact).HasColumnName("id_auth_request_contact");
            entity.Property(e => e.IdDocumentGeneration).HasColumnName("id_document_generation");
            entity.Property(e => e.IdRequestTemplate).HasColumnName("id_request_template");
            entity.Property(e => e.IncludedByDefault).HasColumnName("included_by_default");
            entity.Property(e => e.IncludedForFinishByDefault).HasColumnName("included_for_finish_by_default");
            entity.Property(e => e.IncludedForTempTransByDefault).HasColumnName("included_for_temp_trans_by_default");
            entity.Property(e => e.IncludedForWorkByDefault).HasColumnName("included_for_work_by_default");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsExternal).HasColumnName("is_external");
            entity.Property(e => e.IsLast).HasColumnName("is_last");
            entity.Property(e => e.IsLastForFinish).HasColumnName("is_last_for_finish");
            entity.Property(e => e.IsLastForWork).HasColumnName("is_last_for_work");
            entity.Property(e => e.IsTempTransApprover).HasColumnName("is_temp_trans_approver");
            entity.Property(e => e.ListOrder).HasColumnName("list_order");
        });

        modelBuilder.Entity<DynamicRequestApproversList>(entity =>
        {
            entity.ToTable("dynamic_request_approvers_list");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.ConfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("confirm_date");
            entity.Property(e => e.ConfirmStatus).HasColumnName("confirm_status");
            entity.Property(e => e.IdAuthRequest).HasColumnName("id_auth_request");
            entity.Property(e => e.IdAuthRequestApproverId).HasColumnName("id_auth_request_approver_id");
            entity.Property(e => e.IdOptionRequest).HasColumnName("id_option_request");
            entity.Property(e => e.IdRequestType).HasColumnName("id_request_type");
            entity.Property(e => e.IsAuthReqSent).HasColumnName("is_auth_req_sent");
            entity.Property(e => e.IsLast).HasColumnName("is_last");
            entity.Property(e => e.SentDate)
                .HasColumnType("datetime")
                .HasColumnName("sent_date");
            entity.Property(e => e.Signature)
                .HasColumnType("text")
                .HasColumnName("signature");
        });

        modelBuilder.Entity<DynamicRequestContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dynamic___3213E83F7E34DB72");

            entity.ToTable("dynamic_request_contact");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdContact).HasColumnName("id_contact");
            entity.Property(e => e.IdRequestType).HasColumnName("id_request_type");
            entity.Property(e => e.IsAuthsManager).HasColumnName("is_auths_manager");
            entity.Property(e => e.IsDistributeRequests).HasColumnName("is_distribute_requests");
            entity.Property(e => e.IsRequestsManager).HasColumnName("is_requests_manager");
        });

        modelBuilder.Entity<DynamicRequestContent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dynamic___3213E83F35791C56");

            entity.ToTable("dynamic_request_contents");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentHtml).HasColumnName("content_html");
            entity.Property(e => e.ContentKey)
                .HasMaxLength(50)
                .HasColumnName("content_key");
            entity.Property(e => e.ContentTitle)
                .HasMaxLength(250)
                .HasColumnName("content_title");
            entity.Property(e => e.IdDynamicRequest).HasColumnName("id_dynamic_request");
        });

        modelBuilder.Entity<DynamicRequestDomain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dynamic___3213E83F08122E32");

            entity.ToTable("dynamic_request_domains");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DynamicRequestDynamicFieldsSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__auth_req__3213E83F675ECDAC");

            entity.ToTable("dynamic_request_dynamic_fields_settings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Chackbox1IsRequired).HasColumnName("chackbox1_is_required");
            entity.Property(e => e.Chackbox2IsRequired).HasColumnName("chackbox2_is_required");
            entity.Property(e => e.Chackbox3IsRequired).HasColumnName("chackbox3_is_required");
            entity.Property(e => e.Chackbox4IsRequired).HasColumnName("chackbox4_is_required");
            entity.Property(e => e.Chackbox5IsRequired).HasColumnName("chackbox5_is_required");
            entity.Property(e => e.Checkbox10IsActive).HasColumnName("checkbox10_is_active");
            entity.Property(e => e.Checkbox10IsRequired).HasColumnName("checkbox10_is_required");
            entity.Property(e => e.Checkbox10Label)
                .HasMaxLength(250)
                .HasColumnName("checkbox10_label");
            entity.Property(e => e.Checkbox1IsActive).HasColumnName("checkbox1_is_active");
            entity.Property(e => e.Checkbox1Label)
                .HasMaxLength(250)
                .HasColumnName("checkbox1_label");
            entity.Property(e => e.Checkbox2IsActive).HasColumnName("checkbox2_is_active");
            entity.Property(e => e.Checkbox2Label)
                .HasMaxLength(250)
                .HasColumnName("checkbox2_label");
            entity.Property(e => e.Checkbox3IsActive).HasColumnName("checkbox3_is_active");
            entity.Property(e => e.Checkbox3Label)
                .HasMaxLength(250)
                .HasColumnName("checkbox3_label");
            entity.Property(e => e.Checkbox4IsActive).HasColumnName("checkbox4_is_active");
            entity.Property(e => e.Checkbox4Label)
                .HasMaxLength(250)
                .HasColumnName("checkbox4_label");
            entity.Property(e => e.Checkbox5IsActive).HasColumnName("checkbox5_is_active");
            entity.Property(e => e.Checkbox5Label)
                .HasMaxLength(250)
                .HasColumnName("checkbox5_label");
            entity.Property(e => e.Checkbox6IsActive).HasColumnName("checkbox6_is_active");
            entity.Property(e => e.Checkbox6IsRequired).HasColumnName("checkbox6_is_required");
            entity.Property(e => e.Checkbox6Label)
                .HasMaxLength(250)
                .HasColumnName("checkbox6_label");
            entity.Property(e => e.Checkbox7IsActive).HasColumnName("checkbox7_is_active");
            entity.Property(e => e.Checkbox7IsRequired).HasColumnName("checkbox7_is_required");
            entity.Property(e => e.Checkbox7Label)
                .HasMaxLength(250)
                .HasColumnName("checkbox7_label");
            entity.Property(e => e.Checkbox8IsActive).HasColumnName("checkbox8_is_active");
            entity.Property(e => e.Checkbox8IsRequired).HasColumnName("checkbox8_is_required");
            entity.Property(e => e.Checkbox8Label)
                .HasMaxLength(250)
                .HasColumnName("checkbox8_label");
            entity.Property(e => e.Checkbox9IsActive).HasColumnName("checkbox9_is_active");
            entity.Property(e => e.Checkbox9IsRequired).HasColumnName("checkbox9_is_required");
            entity.Property(e => e.Checkbox9Label)
                .HasMaxLength(250)
                .HasColumnName("checkbox9_label");
            entity.Property(e => e.Datetime1IsActive).HasColumnName("datetime1_is_active");
            entity.Property(e => e.Datetime1IsRequired).HasColumnName("datetime1_is_required");
            entity.Property(e => e.Datetime1Label)
                .HasMaxLength(250)
                .HasColumnName("datetime1_label");
            entity.Property(e => e.Datetime2IsActive).HasColumnName("datetime2_is_active");
            entity.Property(e => e.Datetime2IsRequired).HasColumnName("datetime2_is_required");
            entity.Property(e => e.Datetime2Label)
                .HasMaxLength(250)
                .HasColumnName("datetime2_label");
            entity.Property(e => e.Datetime3IsActive).HasColumnName("datetime3_is_active");
            entity.Property(e => e.Datetime3IsRequired).HasColumnName("datetime3_is_required");
            entity.Property(e => e.Datetime3Label)
                .HasMaxLength(250)
                .HasColumnName("datetime3_label");
            entity.Property(e => e.Datetime4IsActive).HasColumnName("datetime4_is_active");
            entity.Property(e => e.Datetime4IsRequired).HasColumnName("datetime4_is_required");
            entity.Property(e => e.Datetime4Label)
                .HasMaxLength(250)
                .HasColumnName("datetime4_label");
            entity.Property(e => e.Datetime5IsActive).HasColumnName("datetime5_is_active");
            entity.Property(e => e.Datetime5IsRequired).HasColumnName("datetime5_is_required");
            entity.Property(e => e.Datetime5Label)
                .HasMaxLength(250)
                .HasColumnName("datetime5_label");
            entity.Property(e => e.ExtendedText1IsActive).HasColumnName("extended_text1_is_active");
            entity.Property(e => e.ExtendedText1IsRequired).HasColumnName("extended_text1_is_required");
            entity.Property(e => e.ExtendedText1Label)
                .HasMaxLength(250)
                .HasColumnName("extended_text1_label");
            entity.Property(e => e.ExtendedText2IsActive).HasColumnName("extended_text2_is_active");
            entity.Property(e => e.ExtendedText2IsRequired).HasColumnName("extended_text2_is_required");
            entity.Property(e => e.ExtendedText2Label)
                .HasMaxLength(250)
                .HasColumnName("extended_text2_label");
            entity.Property(e => e.ExtendedText3IsActive).HasColumnName("extended_text3_is_active");
            entity.Property(e => e.ExtendedText3IsRequired).HasColumnName("extended_text3_is_required");
            entity.Property(e => e.ExtendedText3Label)
                .HasMaxLength(250)
                .HasColumnName("extended_text3_label");
            entity.Property(e => e.ExtendedText4IsActive).HasColumnName("extended_text4_is_active");
            entity.Property(e => e.ExtendedText4IsRequired).HasColumnName("extended_text4_is_required");
            entity.Property(e => e.ExtendedText4Label)
                .HasMaxLength(250)
                .HasColumnName("extended_text4_label");
            entity.Property(e => e.ExtendedText5IsActive).HasColumnName("extended_text5_is_active");
            entity.Property(e => e.ExtendedText5IsRequired).HasColumnName("extended_text5_is_required");
            entity.Property(e => e.ExtendedText5Label)
                .HasMaxLength(250)
                .HasColumnName("extended_text5_label");
            entity.Property(e => e.IdRequestType).HasColumnName("id_request_type");
            entity.Property(e => e.SelectIsActive).HasColumnName("select_is_active");
            entity.Property(e => e.SelectIsRequired).HasColumnName("select_is_required");
            entity.Property(e => e.Text10EndText)
                .HasMaxLength(250)
                .HasColumnName("text10_end_text");
            entity.Property(e => e.Text10Formula)
                .HasMaxLength(250)
                .HasColumnName("text10_formula");
            entity.Property(e => e.Text10IsActive).HasColumnName("text10_is_active");
            entity.Property(e => e.Text10IsCalculatedField).HasColumnName("text10_is_calculated_field");
            entity.Property(e => e.Text10IsRequired).HasColumnName("text10_is_required");
            entity.Property(e => e.Text10Label)
                .HasMaxLength(250)
                .HasColumnName("text10_label");
            entity.Property(e => e.Text11EndText)
                .HasMaxLength(250)
                .HasColumnName("text11_end_text");
            entity.Property(e => e.Text11Formula)
                .HasMaxLength(250)
                .HasColumnName("text11_formula");
            entity.Property(e => e.Text11IsActive).HasColumnName("text11_is_active");
            entity.Property(e => e.Text11IsCalculatedField).HasColumnName("text11_is_calculated_field");
            entity.Property(e => e.Text11IsRequired).HasColumnName("text11_is_required");
            entity.Property(e => e.Text11Label)
                .HasMaxLength(250)
                .HasColumnName("text11_label");
            entity.Property(e => e.Text12EndText)
                .HasMaxLength(250)
                .HasColumnName("text12_end_text");
            entity.Property(e => e.Text12Formula)
                .HasMaxLength(250)
                .HasColumnName("text12_formula");
            entity.Property(e => e.Text12IsActive).HasColumnName("text12_is_active");
            entity.Property(e => e.Text12IsCalculatedField).HasColumnName("text12_is_calculated_field");
            entity.Property(e => e.Text12IsRequired).HasColumnName("text12_is_required");
            entity.Property(e => e.Text12Label)
                .HasMaxLength(250)
                .HasColumnName("text12_label");
            entity.Property(e => e.Text13IsActive).HasColumnName("text13_is_active");
            entity.Property(e => e.Text13IsRequired).HasColumnName("text13_is_required");
            entity.Property(e => e.Text13Label)
                .HasMaxLength(250)
                .HasColumnName("text13_label");
            entity.Property(e => e.Text14IsActive).HasColumnName("text14_is_active");
            entity.Property(e => e.Text14IsRequired).HasColumnName("text14_is_required");
            entity.Property(e => e.Text14Label)
                .HasMaxLength(250)
                .HasColumnName("text14_label");
            entity.Property(e => e.Text15IsActive).HasColumnName("text15_is_active");
            entity.Property(e => e.Text15IsRequired).HasColumnName("text15_is_required");
            entity.Property(e => e.Text15Label)
                .HasMaxLength(250)
                .HasColumnName("text15_label");
            entity.Property(e => e.Text16IsActive).HasColumnName("text16_is_active");
            entity.Property(e => e.Text16IsRequired).HasColumnName("text16_is_required");
            entity.Property(e => e.Text16Label)
                .HasMaxLength(250)
                .HasColumnName("text16_label");
            entity.Property(e => e.Text17IsActive).HasColumnName("text17_is_active");
            entity.Property(e => e.Text17IsRequired).HasColumnName("text17_is_required");
            entity.Property(e => e.Text17Label)
                .HasMaxLength(250)
                .HasColumnName("text17_label");
            entity.Property(e => e.Text18IsActive).HasColumnName("text18_is_active");
            entity.Property(e => e.Text18IsRequired).HasColumnName("text18_is_required");
            entity.Property(e => e.Text18Label)
                .HasMaxLength(250)
                .HasColumnName("text18_label");
            entity.Property(e => e.Text19IsActive).HasColumnName("text19_is_active");
            entity.Property(e => e.Text19IsRequired).HasColumnName("text19_is_required");
            entity.Property(e => e.Text19Label)
                .HasMaxLength(250)
                .HasColumnName("text19_label");
            entity.Property(e => e.Text1IsActive).HasColumnName("text1_is_active");
            entity.Property(e => e.Text1IsRequired).HasColumnName("text1_is_required");
            entity.Property(e => e.Text1Label)
                .HasMaxLength(250)
                .HasColumnName("text1_label");
            entity.Property(e => e.Text1Placeholder)
                .HasMaxLength(250)
                .HasColumnName("text1_placeholder");
            entity.Property(e => e.Text20IsActive).HasColumnName("text20_is_active");
            entity.Property(e => e.Text20IsRequired).HasColumnName("text20_is_required");
            entity.Property(e => e.Text20Label)
                .HasMaxLength(250)
                .HasColumnName("text20_label");
            entity.Property(e => e.Text21IsActive).HasColumnName("text21_is_active");
            entity.Property(e => e.Text21IsRequired).HasColumnName("text21_is_required");
            entity.Property(e => e.Text21Label)
                .HasMaxLength(250)
                .HasColumnName("text21_label");
            entity.Property(e => e.Text22IsActive).HasColumnName("text22_is_active");
            entity.Property(e => e.Text22IsRequired).HasColumnName("text22_is_required");
            entity.Property(e => e.Text22Label)
                .HasMaxLength(250)
                .HasColumnName("text22_label");
            entity.Property(e => e.Text23IsActive).HasColumnName("text23_is_active");
            entity.Property(e => e.Text23IsRequired).HasColumnName("text23_is_required");
            entity.Property(e => e.Text23Label)
                .HasMaxLength(250)
                .HasColumnName("text23_label");
            entity.Property(e => e.Text24IsActive).HasColumnName("text24_is_active");
            entity.Property(e => e.Text24IsRequired).HasColumnName("text24_is_required");
            entity.Property(e => e.Text24Label)
                .HasMaxLength(250)
                .HasColumnName("text24_label");
            entity.Property(e => e.Text25IsActive).HasColumnName("text25_is_active");
            entity.Property(e => e.Text25IsRequired).HasColumnName("text25_is_required");
            entity.Property(e => e.Text25Label)
                .HasMaxLength(250)
                .HasColumnName("text25_label");
            entity.Property(e => e.Text2IsActive).HasColumnName("text2_is_active");
            entity.Property(e => e.Text2IsRequired).HasColumnName("text2_is_required");
            entity.Property(e => e.Text2Label)
                .HasMaxLength(250)
                .HasColumnName("text2_label");
            entity.Property(e => e.Text2Placeholder)
                .HasMaxLength(250)
                .HasColumnName("text2_placeholder");
            entity.Property(e => e.Text3IsActive).HasColumnName("text3_is_active");
            entity.Property(e => e.Text3IsRequired).HasColumnName("text3_is_required");
            entity.Property(e => e.Text3Label)
                .HasMaxLength(250)
                .HasColumnName("text3_label");
            entity.Property(e => e.Text3Placeholder)
                .HasMaxLength(250)
                .HasColumnName("text3_placeholder");
            entity.Property(e => e.Text4IsActive).HasColumnName("text4_is_active");
            entity.Property(e => e.Text4IsRequired).HasColumnName("text4_is_required");
            entity.Property(e => e.Text4Label)
                .HasMaxLength(250)
                .HasColumnName("text4_label");
            entity.Property(e => e.Text4Placeholder)
                .HasMaxLength(250)
                .HasColumnName("text4_placeholder");
            entity.Property(e => e.Text5IsActive).HasColumnName("text5_is_active");
            entity.Property(e => e.Text5IsRequired).HasColumnName("text5_is_required");
            entity.Property(e => e.Text5Label)
                .HasMaxLength(250)
                .HasColumnName("text5_label");
            entity.Property(e => e.Text5Placeholder)
                .HasMaxLength(250)
                .HasColumnName("text5_placeholder");
            entity.Property(e => e.Text6IsActive).HasColumnName("text6_is_active");
            entity.Property(e => e.Text6IsRequired).HasColumnName("text6_is_required");
            entity.Property(e => e.Text6Label)
                .HasMaxLength(250)
                .HasColumnName("text6_label");
            entity.Property(e => e.Text7IsActive).HasColumnName("text7_is_active");
            entity.Property(e => e.Text7IsRequired).HasColumnName("text7_is_required");
            entity.Property(e => e.Text7Label)
                .HasMaxLength(250)
                .HasColumnName("text7_label");
            entity.Property(e => e.Text8IsActive).HasColumnName("text8_is_active");
            entity.Property(e => e.Text8IsRequired).HasColumnName("text8_is_required");
            entity.Property(e => e.Text8Label)
                .HasMaxLength(250)
                .HasColumnName("text8_label");
            entity.Property(e => e.Text9IsActive).HasColumnName("text9_is_active");
            entity.Property(e => e.Text9IsRequired).HasColumnName("text9_is_required");
            entity.Property(e => e.Text9Label)
                .HasMaxLength(250)
                .HasColumnName("text9_label");
            entity.Property(e => e.TextSelectLabel)
                .HasColumnType("text")
                .HasColumnName("text_select_label");
            entity.Property(e => e.TextSelectOptions)
                .HasColumnType("text")
                .HasColumnName("text_select_options");
        });

        modelBuilder.Entity<DynamicRequestDynamicFieldsValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__auth_req__3213E83FD2E38709");

            entity.ToTable("dynamic_request_dynamic_fields_values");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Checkbox10Value).HasColumnName("checkbox10_value");
            entity.Property(e => e.Checkbox1Value).HasColumnName("checkbox1_value");
            entity.Property(e => e.Checkbox2Value).HasColumnName("checkbox2_value");
            entity.Property(e => e.Checkbox3Value).HasColumnName("checkbox3_value");
            entity.Property(e => e.Checkbox4Value).HasColumnName("checkbox4_value");
            entity.Property(e => e.Checkbox5Value).HasColumnName("checkbox5_value");
            entity.Property(e => e.Checkbox6Value).HasColumnName("checkbox6_value");
            entity.Property(e => e.Checkbox7Value).HasColumnName("checkbox7_value");
            entity.Property(e => e.Checkbox8Value).HasColumnName("checkbox8_value");
            entity.Property(e => e.Checkbox9Value).HasColumnName("checkbox9_value");
            entity.Property(e => e.Datetime1Value)
                .HasColumnType("datetime")
                .HasColumnName("datetime1_value");
            entity.Property(e => e.Datetime2Value)
                .HasColumnType("datetime")
                .HasColumnName("datetime2_value");
            entity.Property(e => e.Datetime3Value)
                .HasColumnType("datetime")
                .HasColumnName("datetime3_value");
            entity.Property(e => e.Datetime4Value)
                .HasColumnType("datetime")
                .HasColumnName("datetime4_value");
            entity.Property(e => e.Datetime5Value)
                .HasColumnType("datetime")
                .HasColumnName("datetime5_value");
            entity.Property(e => e.ExtendedText1Value)
                .HasColumnType("text")
                .HasColumnName("extended_text1_value");
            entity.Property(e => e.ExtendedText2Value)
                .HasColumnType("text")
                .HasColumnName("extended_text2_value");
            entity.Property(e => e.ExtendedText3Value)
                .HasColumnType("text")
                .HasColumnName("extended_text3_value");
            entity.Property(e => e.ExtendedText4Value)
                .HasColumnType("text")
                .HasColumnName("extended_text4_value");
            entity.Property(e => e.ExtendedText5Value)
                .HasColumnType("text")
                .HasColumnName("extended_text5_value");
            entity.Property(e => e.IdAuthNumber).HasColumnName("id_auth_number");
            entity.Property(e => e.IdSetting).HasColumnName("id_setting");
            entity.Property(e => e.Text10Value)
                .HasMaxLength(250)
                .HasColumnName("text10_value");
            entity.Property(e => e.Text11Value)
                .HasMaxLength(250)
                .HasColumnName("text11_value");
            entity.Property(e => e.Text12Value)
                .HasMaxLength(250)
                .HasColumnName("text12_value");
            entity.Property(e => e.Text13Value)
                .HasMaxLength(250)
                .HasColumnName("text13_value");
            entity.Property(e => e.Text14Value)
                .HasMaxLength(250)
                .HasColumnName("text14_value");
            entity.Property(e => e.Text15Value)
                .HasMaxLength(250)
                .HasColumnName("text15_value");
            entity.Property(e => e.Text16Value)
                .HasMaxLength(250)
                .HasColumnName("text16_value");
            entity.Property(e => e.Text17Value)
                .HasMaxLength(250)
                .HasColumnName("text17_value");
            entity.Property(e => e.Text18Value)
                .HasMaxLength(250)
                .HasColumnName("text18_value");
            entity.Property(e => e.Text19Value)
                .HasMaxLength(250)
                .HasColumnName("text19_value");
            entity.Property(e => e.Text1Value)
                .HasMaxLength(250)
                .HasColumnName("text1_value");
            entity.Property(e => e.Text20Value)
                .HasMaxLength(250)
                .HasColumnName("text20_value");
            entity.Property(e => e.Text21Value)
                .HasMaxLength(250)
                .HasColumnName("text21_value");
            entity.Property(e => e.Text22Value)
                .HasMaxLength(250)
                .HasColumnName("text22_value");
            entity.Property(e => e.Text23Value)
                .HasMaxLength(250)
                .HasColumnName("text23_value");
            entity.Property(e => e.Text24Value)
                .HasMaxLength(250)
                .HasColumnName("text24_value");
            entity.Property(e => e.Text25Value)
                .HasMaxLength(250)
                .HasColumnName("text25_value");
            entity.Property(e => e.Text2Value)
                .HasMaxLength(250)
                .HasColumnName("text2_value");
            entity.Property(e => e.Text3Value)
                .HasMaxLength(250)
                .HasColumnName("text3_value");
            entity.Property(e => e.Text4Value)
                .HasMaxLength(250)
                .HasColumnName("text4_value");
            entity.Property(e => e.Text5Value)
                .HasMaxLength(250)
                .HasColumnName("text5_value");
            entity.Property(e => e.Text6Value)
                .HasMaxLength(250)
                .HasColumnName("text6_value");
            entity.Property(e => e.Text7Value)
                .HasMaxLength(250)
                .HasColumnName("text7_value");
            entity.Property(e => e.Text8Value)
                .HasMaxLength(250)
                .HasColumnName("text8_value");
            entity.Property(e => e.Text9Value)
                .HasMaxLength(250)
                .HasColumnName("text9_value");
        });

        modelBuilder.Entity<DynamicRequestGeneralSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dynamic___3213E83F80416C29");

            entity.ToTable("dynamic_request_general_settings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdminUpdate).HasColumnName("admin_update");
            entity.Property(e => e.ApproverStatus).HasColumnName("approver_status");
            entity.Property(e => e.CertificateValidityPeriod).HasColumnName("certificate_validity_period");
            entity.Property(e => e.ConfirmationDetails).HasColumnName("confirmation_details");
            entity.Property(e => e.Contacts).HasColumnName("contacts");
            entity.Property(e => e.ContractorCommitment)
                .HasDefaultValueSql("((0))")
                .HasColumnName("contractor_commitment");
            entity.Property(e => e.CoordinationProtocol).HasColumnName("coordination_protocol");
            entity.Property(e => e.Documentation).HasColumnName("documentation");
            entity.Property(e => e.GenerateProcessTerminationDocument)
                .HasMaxLength(50)
                .HasColumnName("generate_process_termination_document");
            entity.Property(e => e.IdRequestType).HasColumnName("id_request_type");
            entity.Property(e => e.IsDisplayInNewRequest).HasColumnName("is_display_in_new_request");
            entity.Property(e => e.JobDetails).HasColumnName("job_details");
            entity.Property(e => e.Msg).HasColumnName("msg");
            entity.Property(e => e.ProcessTerminationDocumentId)
                .HasMaxLength(50)
                .HasColumnName("process_termination_document_id");
            entity.Property(e => e.RequestLocation).HasColumnName("request_location");
            entity.Property(e => e.RequestStatus).HasColumnName("request_status");
            entity.Property(e => e.RequestType).HasColumnName("request_type");
            entity.Property(e => e.RequiredDocuments).HasColumnName("required_documents");
            entity.Property(e => e.Resources)
                .HasDefaultValueSql("((0))")
                .HasColumnName("resources");
            entity.Property(e => e.ShowMap).HasColumnName("show_map");
            entity.Property(e => e.ShowMmg).HasColumnName("show_mmg");
            entity.Property(e => e.TrafficRegulationProcess).HasColumnName("traffic_regulation_process");
        });

        modelBuilder.Entity<DynamicRequestRequiredDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dynamic___3213E83FA779462E");

            entity.ToTable("dynamic_request_required_docs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdDynamicRequest).HasColumnName("id_dynamic_request");
            entity.Property(e => e.IdRequiredDoc).HasColumnName("id_required_doc");
        });

        modelBuilder.Entity<DynamicRequestStaticFieldsSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__req_type__3213E83FA6F4D044");

            entity.ToTable("dynamic_request_static_fields_settings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdditionalAuthorities).HasColumnName("additional_authorities");
            entity.Property(e => e.AdditionalAuthoritiesIsRequired).HasColumnName("additional_authorities_is_required");
            entity.Property(e => e.AuthorityConstructor).HasColumnName("authority_constructor");
            entity.Property(e => e.AuthorityConstructorIsRequired).HasColumnName("authority_constructor_is_required");
            entity.Property(e => e.AuthorityContactSetIsPrivate).HasColumnName("authority_contact_set_is_private");
            entity.Property(e => e.AuthorityContactSetIsRequired).HasColumnName("authority_contact_set_is_required");
            entity.Property(e => e.AuthorityFinishCoordinator).HasColumnName("authority_finish_coordinator");
            entity.Property(e => e.AuthorityFinishCoordinatorIsRequired).HasColumnName("authority_finish_coordinator_is_required");
            entity.Property(e => e.AuthorityFor).HasColumnName("authority_for");
            entity.Property(e => e.AuthorityForIsRequired).HasColumnName("authority_for_is_required");
            entity.Property(e => e.AuthorityPlanner).HasColumnName("authority_planner");
            entity.Property(e => e.AuthorityPlannerIsRequired).HasColumnName("authority_planner_is_required");
            entity.Property(e => e.AuthoritySupervisor).HasColumnName("authority_supervisor");
            entity.Property(e => e.AuthoritySupervisorIsRequired).HasColumnName("authority_supervisor_is_required");
            entity.Property(e => e.AuthorityWorkCoordinator).HasColumnName("authority_work_coordinator");
            entity.Property(e => e.AuthorityWorkCoordinatorIsRequired).HasColumnName("authority_work_coordinator_is_required");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.CommentsIsRequired).HasColumnName("comments_is_required");
            entity.Property(e => e.ContactSet).HasColumnName("contact_set");
            entity.Property(e => e.CopyingContactSetDetailsInRequestRoll).HasColumnName("copying_contact_set_details_in_request_roll");
            entity.Property(e => e.CreatingContactAndSendingEmailForAuthorityFor).HasColumnName("creating_contact_and_sending_email_for_authority_for");
            entity.Property(e => e.CreatingContactAndSendingEmailForConstructor).HasColumnName("creating_contact_and_sending_email_for_constructor");
            entity.Property(e => e.CreatingContactAndSendingEmailForPlanner).HasColumnName("creating_contact_and_sending_email_for_planner");
            entity.Property(e => e.CreatingContactAndSendingEmailForSupervisor).HasColumnName("creating_contact_and_sending_email_for_supervisor");
            entity.Property(e => e.DiggingDepth).HasColumnName("digging_depth");
            entity.Property(e => e.DiggingDepthIsRequired).HasColumnName("digging_depth_is_required");
            entity.Property(e => e.DiggingLength).HasColumnName("digging_length");
            entity.Property(e => e.DiggingLengthIsRequired).HasColumnName("digging_length_is_required");
            entity.Property(e => e.DiggingWidth).HasColumnName("digging_width");
            entity.Property(e => e.DiggingWidthIsRequired).HasColumnName("digging_width_is_required");
            entity.Property(e => e.GushAndHelka).HasColumnName("gush_and_helka");
            entity.Property(e => e.GushAndHelkaIsRequired).HasColumnName("gush_and_helka_is_required");
            entity.Property(e => e.IdRequestType).HasColumnName("id_request_type");
            entity.Property(e => e.OptionalTitleAdditionalAuthorities)
                .HasMaxLength(100)
                .HasColumnName("optional_title_additional_authorities");
            entity.Property(e => e.OptionalTitleAddress)
                .HasMaxLength(100)
                .HasColumnName("optional_title_address");
            entity.Property(e => e.OptionalTitleAuthorityConstructor)
                .HasMaxLength(100)
                .HasColumnName("optional_title_authority_constructor");
            entity.Property(e => e.OptionalTitleAuthorityFinishCoordinator)
                .HasMaxLength(100)
                .HasColumnName("optional_title_authority_finish_coordinator");
            entity.Property(e => e.OptionalTitleAuthorityFor)
                .HasMaxLength(100)
                .HasColumnName("optional_title_authority_for");
            entity.Property(e => e.OptionalTitleAuthorityPlanner)
                .HasMaxLength(100)
                .HasColumnName("optional_title_authority_planner");
            entity.Property(e => e.OptionalTitleAuthoritySupervisor)
                .HasMaxLength(100)
                .HasColumnName("optional_title_authority_supervisor");
            entity.Property(e => e.OptionalTitleAuthorityWorkCoordinator)
                .HasMaxLength(100)
                .HasColumnName("optional_title_authority_work_coordinator");
            entity.Property(e => e.OptionalTitleContactSet)
                .HasMaxLength(100)
                .HasColumnName("optional_title_contact_set");
            entity.Property(e => e.PlanNumber).HasColumnName("plan_number");
            entity.Property(e => e.PlanNumberIsRequired).HasColumnName("plan_number_is_required");
            entity.Property(e => e.RequestOkCheckbox)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("request_ok_checkbox");
            entity.Property(e => e.RequestOkCheckboxDetails)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('בלחיצה על כפתור \"המשך\" אני מתחייב שפרטי העבודה שמילאתי בטופס הבקשה נכונים')")
                .HasColumnName("request_ok_checkbox_details");
            entity.Property(e => e.RequestOkCheckboxTitle)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('הנני מאשר את פרטי הבקשה')")
                .HasColumnName("request_ok_checkbox_title");
            entity.Property(e => e.Street).HasColumnName("street");
            entity.Property(e => e.StreetIsRequired).HasColumnName("street_is_required");
            entity.Property(e => e.StreetIsSimpleAddress).HasColumnName("street_is_simple_address");
            entity.Property(e => e.WorkDescription).HasColumnName("work_description");
            entity.Property(e => e.WorkDescriptionIsRequired).HasColumnName("work_description_is_required");
            entity.Property(e => e.WorkDetails).HasColumnName("work_details");
            entity.Property(e => e.WorkType).HasColumnName("work_type");
            entity.Property(e => e.WorkTypeIsRequired).HasColumnName("work_type_is_required");
        });

        modelBuilder.Entity<Funding>(entity =>
        {
            entity.ToTable("funding");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comments)
                .HasColumnType("text")
                .HasColumnName("comments");
            entity.Property(e => e.IdFundingSource).HasColumnName("id_funding_source");
            entity.Property(e => e.IdFundingStatus).HasColumnName("id_funding_status");
            entity.Property(e => e.IsApproved).HasColumnName("is_approved");
            entity.Property(e => e.TabarName)
                .HasMaxLength(350)
                .HasColumnName("tabar_name");
            entity.Property(e => e.TabarNumber).HasColumnName("tabar_number");
            entity.Property(e => e.TotalFundingHeight)
                .HasColumnType("money")
                .HasColumnName("total_funding_height");
            entity.Property(e => e.TotalMoneyLeft)
                .HasColumnType("money")
                .HasColumnName("total_money_left");
            entity.Property(e => e.TotalMoneyUsed)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("total_money_used");
        });

        modelBuilder.Entity<FundingAppendix>(entity =>
        {
            entity.ToTable("funding_appendix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Appendix)
                .HasMaxLength(250)
                .HasColumnName("appendix");
            entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");
        });

        modelBuilder.Entity<FundingSource>(entity =>
        {
            entity.ToTable("funding_source");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.IdFundingType).HasColumnName("id_funding_type");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
        });

        modelBuilder.Entity<FundingStartBudget>(entity =>
        {
            entity.ToTable("funding_start_budget");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdFunding).HasColumnName("id_funding");
            entity.Property(e => e.StartBudget)
                .HasColumnType("money")
                .HasColumnName("start_budget");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<FundingStatus>(entity =>
        {
            entity.ToTable("funding_status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<FundingTransfer>(entity =>
        {
            entity.ToTable("funding_transfer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdFunding).HasColumnName("id_funding");
            entity.Property(e => e.IdProject).HasColumnName("id_project");
            entity.Property(e => e.IdProjectStage).HasColumnName("id_project_stage");
            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.TransferCost)
                .HasColumnType("money")
                .HasColumnName("transfer_cost");
            entity.Property(e => e.TransferDate)
                .HasColumnType("date")
                .HasColumnName("transfer_date");
        });

        modelBuilder.Entity<FundingType>(entity =>
        {
            entity.ToTable("funding_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<LocationsDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("locations_data$");

            entity.Property(e => e.Gush)
                .HasMaxLength(255)
                .HasColumnName("gush");
            entity.Property(e => e.Helka)
                .HasMaxLength(255)
                .HasColumnName("helka");
            entity.Property(e => e.StreetId)
                .HasMaxLength(255)
                .HasColumnName("street_id");
            entity.Property(e => e.StreetName)
                .HasMaxLength(255)
                .HasColumnName("street_name");
            entity.Property(e => e.StreetNum)
                .HasMaxLength(255)
                .HasColumnName("street_num");
        });

        modelBuilder.Entity<MeetingDocument>(entity =>
        {
            entity.ToTable("meeting_document");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentType)
                .HasMaxLength(50)
                .HasColumnName("content_type");
            entity.Property(e => e.Description)
                .HasDefaultValueSql("('')")
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Filename)
                .HasMaxLength(150)
                .HasColumnName("filename");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.MeetId).HasColumnName("meet_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.UploadDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("upload_date");

            entity.HasOne(d => d.Meet).WithMany(p => p.MeetingDocuments)
                .HasForeignKey(d => d.MeetId)
                .HasConstraintName("FK_meeting_document_meeting_notes");
        });

        modelBuilder.Entity<MeetingNote>(entity =>
        {
            entity.ToTable("meeting_notes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content)
                .HasColumnType("ntext")
                .HasColumnName("content");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DateAdd)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Place)
                .HasMaxLength(50)
                .HasColumnName("place");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.Subject)
                .HasMaxLength(150)
                .HasColumnName("subject");

            entity.HasOne(d => d.Project).WithMany(p => p.MeetingNotes)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_meeting_notes_project");
        });

        modelBuilder.Entity<MeetingParticipant>(entity =>
        {
            entity.ToTable("meeting_participant");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MeetId).HasColumnName("meet_id");
            entity.Property(e => e.ParticipantName)
                .HasMaxLength(100)
                .HasColumnName("participant_name");
            entity.Property(e => e.TypeName)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("type_name");

            entity.HasOne(d => d.Meet).WithMany(p => p.MeetingParticipants)
                .HasForeignKey(d => d.MeetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_meeting_participant_meeting_notes");
        });

        modelBuilder.Entity<MtlAuthority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mtl_auth__3213E83F681F8DED");

            entity.ToTable("mtl_authority");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthorityName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("authority_name");
            entity.Property(e => e.DbName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("db_name");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.LastSync)
                .HasColumnType("datetime")
                .HasColumnName("last_sync");
        });

        modelBuilder.Entity<OrderJobstart>(entity =>
        {
            entity.ToTable("order_jobstart");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateOrder)
                .HasColumnType("date")
                .HasColumnName("date_order");
            entity.Property(e => e.PaymentCondition)
                .HasMaxLength(100)
                .HasColumnName("payment_condition");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(100)
                .HasColumnName("project_name");
            entity.Property(e => e.ProjectNumber)
                .HasMaxLength(50)
                .HasColumnName("project_number");
            entity.Property(e => e.StartOrderSum)
                .HasMaxLength(100)
                .HasColumnName("start_order_sum");
            entity.Property(e => e.TenderSolution)
                .HasMaxLength(100)
                .HasColumnName("tender_solution");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
            entity.Property(e => e.ToOrder)
                .HasMaxLength(50)
                .HasColumnName("to_order");
            entity.Property(e => e.TypeActivity).HasColumnName("type_activity");
            entity.Property(e => e.TypeActivityTxt)
                .HasMaxLength(100)
                .HasColumnName("type_activity_txt");
        });

        modelBuilder.Entity<PaymentCondition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_payments_conditions1");

            entity.ToTable("payment_conditions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PaymentSheetOrder>(entity =>
        {
            entity.ToTable("payment_sheet_order");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateKabala)
                .HasColumnType("date")
                .HasColumnName("date_kabala");
            entity.Property(e => e.DateMesira)
                .HasColumnType("date")
                .HasColumnName("date_mesira");
            entity.Property(e => e.IdPaymentSheet).HasColumnName("id_payment_sheet");
            entity.Property(e => e.IdProject).HasColumnName("id_project");
            entity.Property(e => e.IdProjectFunding).HasColumnName("id_project_funding");
            entity.Property(e => e.IsApproved).HasColumnName("is_approved");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .HasColumnName("order_number");
        });

        modelBuilder.Entity<PaymentSheetUseFundingSource>(entity =>
        {
            entity.ToTable("payment_sheet_use_funding_sources");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdPaymentSheet).HasColumnName("id_payment_sheet");
            entity.Property(e => e.IdProjectFunding).HasColumnName("id_project_funding");
            entity.Property(e => e.Percentage)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("percentage");
        });

        modelBuilder.Entity<PaymentUnit>(entity =>
        {
            entity.ToTable("payment_unit");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.UnitDepName)
                .HasMaxLength(100)
                .HasColumnName("unit_dep_name");
            entity.Property(e => e.UnitEmail)
                .HasMaxLength(150)
                .HasColumnName("unit_email");
            entity.Property(e => e.UnitManagerName)
                .HasMaxLength(100)
                .HasColumnName("unit_manager_name");
        });

        modelBuilder.Entity<PaymentsSheet>(entity =>
        {
            entity.ToTable("payments_sheet");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BillsNumber).HasColumnName("bills_number");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("date")
                .HasColumnName("created_date");
            entity.Property(e => e.IdCurrentUserConfirm).HasColumnName("id_current_user_confirm");
            entity.Property(e => e.IdFunding).HasColumnName("id_funding");
            entity.Property(e => e.IdProject).HasColumnName("id_project");
            entity.Property(e => e.IdProjectManager).HasColumnName("id_project_manager");
            entity.Property(e => e.IdProjectStage).HasColumnName("id_project_stage");
            entity.Property(e => e.IdPsStatus).HasColumnName("id_ps_status");
            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.IdSupplierType).HasColumnName("id_supplier_type");
            entity.Property(e => e.IsCommissionByPrecent).HasColumnName("is_commission_by_precent");
            entity.Property(e => e.IsFixedPrice).HasColumnName("is_fixed_price");
            entity.Property(e => e.IsImp).HasColumnName("is_imp");
            entity.Property(e => e.IsProjectImplementor).HasColumnName("is_project_implementor");
            entity.Property(e => e.IsRetrofitted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("is_retrofitted");
            entity.Property(e => e.MeasureBill).HasColumnName("measure_bill");
            entity.Property(e => e.PercentCommissionPayment).HasColumnName("percent_Commission_payment");
            entity.Property(e => e.PercentHeapByEstimation).HasColumnName("percent_heap_by_estimation");
            entity.Property(e => e.PercentHeapByImplementation).HasColumnName("percent_heap_by_implementation");
            entity.Property(e => e.PercentPayment).HasColumnName("percent_payment");
            entity.Property(e => e.PrecentMaam).HasColumnName("precent_maam");
            entity.Property(e => e.PriceByEstimation)
                .HasColumnType("money")
                .HasColumnName("price_by_estimation");
            entity.Property(e => e.PriceByEstimationWithVat)
                .HasColumnType("money")
                .HasColumnName("price_by_estimation_with_vat");
            entity.Property(e => e.PriceByImplementation)
                .HasColumnType("money")
                .HasColumnName("price_by_implementation");
            entity.Property(e => e.PriceByImplementationWithVat)
                .HasColumnType("money")
                .HasColumnName("price_by_implementation_with_vat");
            entity.Property(e => e.PriceCompanyByEstimation)
                .HasColumnType("money")
                .HasColumnName("price_company_by_estimation");
            entity.Property(e => e.PriceCompanyByEstimationWithVat)
                .HasColumnType("money")
                .HasColumnName("price_company_by_estimation_with_vat");
            entity.Property(e => e.PriceCompanyByImplementation)
                .HasColumnType("money")
                .HasColumnName("price_company_by_implementation");
            entity.Property(e => e.PriceCompanyByImplementationWithVat)
                .HasColumnType("money")
                .HasColumnName("price_company_by_implementation_with_vat");
            entity.Property(e => e.PsNumber)
                .HasMaxLength(20)
                .HasColumnName("ps_number");
            entity.Property(e => e.TitleName)
                .HasMaxLength(250)
                .HasColumnName("title_name");
            entity.Property(e => e.TotalCostAfterIncreaseByEstimation)
                .HasColumnType("money")
                .HasColumnName("total_cost_after_increase_by_estimation");
            entity.Property(e => e.TotalCostAfterIncreaseByImplementation)
                .HasColumnType("money")
                .HasColumnName("total_cost_after_increase_by_implementation");
            entity.Property(e => e.TotalPaymentApprovalByEstimation)
                .HasColumnType("money")
                .HasColumnName("total_payment_approval_by_estimation");
            entity.Property(e => e.TotalPaymentApprovalByImplementation)
                .HasColumnType("money")
                .HasColumnName("total_payment_approval_by_implementation");
            entity.Property(e => e.TotalPaymentPercentByEstimation)
                .HasColumnType("money")
                .HasColumnName("total_payment_percent_by_estimation");
            entity.Property(e => e.TotalPaymentPercentByImplementation)
                .HasColumnType("money")
                .HasColumnName("total_payment_percent_by_implementation");
            entity.Property(e => e.TotalPaymentWithVatByEstimation)
                .HasColumnType("money")
                .HasColumnName("total_payment_with_vat_by_estimation");
            entity.Property(e => e.TotalPaymentWithVatByImplementation)
                .HasColumnType("money")
                .HasColumnName("total_payment_with_vat_by_implementation");
            entity.Property(e => e.TotalPercentHeapByEstimation2).HasColumnName("total_percent_heap_by_estimation2");
            entity.Property(e => e.TotalPercentHeapByImplementation).HasColumnName("total_percent_heap_by_implementation");
            entity.Property(e => e.TotalReductionByEstimation)
                .HasColumnType("money")
                .HasColumnName("total_reduction_by_estimation");
            entity.Property(e => e.TotalReductionByImplementation)
                .HasColumnType("money")
                .HasColumnName("total_reduction_by_implementation");

            entity.HasOne(d => d.IdProjectNavigation).WithMany(p => p.PaymentsSheets)
                .HasForeignKey(d => d.IdProject)
                .HasConstraintName("FK_payments_sheet_project");
        });

        modelBuilder.Entity<PaymentsSheetApproval>(entity =>
        {
            entity.ToTable("payments_sheet_approvals");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("date")
                .HasColumnName("approved_date");
            entity.Property(e => e.IdPaymentSheet).HasColumnName("id_payment_sheet");
            entity.Property(e => e.IdProject).HasColumnName("id_project");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.IdUserApproved).HasColumnName("id_user_approved");
            entity.Property(e => e.IsApproved).HasColumnName("is_approved");

            entity.HasOne(d => d.IdPaymentSheetNavigation).WithMany(p => p.PaymentsSheetApprovals)
                .HasForeignKey(d => d.IdPaymentSheet)
                .HasConstraintName("FK_payments_sheet_approvals_payments_sheet");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.ToTable("project");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActingFinishDate)
                .HasColumnType("date")
                .HasColumnName("acting_finish_date");
            entity.Property(e => e.BudgetByFunding)
                .HasColumnType("money")
                .HasColumnName("budget_by_funding");
            entity.Property(e => e.BudgetEvaluation)
                .HasColumnType("money")
                .HasColumnName("budget_evaluation");
            entity.Property(e => e.BudgetFinal)
                .HasColumnType("money")
                .HasColumnName("budget_final");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Date1Planning)
                .HasColumnType("date")
                .HasColumnName("date1_planning");
            entity.Property(e => e.Date2Auction)
                .HasColumnType("date")
                .HasColumnName("date2_auction");
            entity.Property(e => e.Date3Organize)
                .HasColumnType("date")
                .HasColumnName("date3_organize");
            entity.Property(e => e.Date4Implementation)
                .HasColumnType("date")
                .HasColumnName("date4_implementation");
            entity.Property(e => e.Date5Delivery)
                .HasColumnType("date")
                .HasColumnName("date5_delivery");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("date_create");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EstimateFinishDate)
                .HasColumnType("date")
                .HasColumnName("estimate_finish_date");
            entity.Property(e => e.ExpirationDateBedekGuarantee)
                .HasColumnType("date")
                .HasColumnName("expiration_date_bedek_guarantee");
            entity.Property(e => e.ExpirationDatePerformanceGuarantee)
                .HasColumnType("date")
                .HasColumnName("expiration_date_performance_guarantee");
            entity.Property(e => e.IdFunding).HasColumnName("id_funding");
            entity.Property(e => e.IdProjectManager).HasColumnName("id_project_manager");
            entity.Property(e => e.IdProjectSupervisor).HasColumnName("id_project_supervisor");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.IsImp).HasColumnName("is_imp");
            entity.Property(e => e.IsSubProject).HasColumnName("is_subProject");
            entity.Property(e => e.LastProjectUpdate)
                .HasColumnType("date")
                .HasColumnName("last_project_update");
            entity.Property(e => e.LocationAddress)
                .HasMaxLength(150)
                .HasColumnName("location_address");
            entity.Property(e => e.LocationLat).HasColumnName("location_lat");
            entity.Property(e => e.LocationLong).HasColumnName("location_long");
            entity.Property(e => e.MasterProjectId).HasColumnName("master_project_id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.OrderDate)
                .HasColumnType("date")
                .HasColumnName("order_date");
            entity.Property(e => e.OrderDepartment)
                .HasMaxLength(50)
                .HasColumnName("order_department");
            entity.Property(e => e.OrderName)
                .HasMaxLength(50)
                .HasColumnName("order_name");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .HasColumnName("order_number");
            entity.Property(e => e.PaymentsConditionsId).HasColumnName("payments_conditions_id");
            entity.Property(e => e.PercentBedekGuarantee)
                .HasColumnType("smallmoney")
                .HasColumnName("percent_bedek_guarantee");
            entity.Property(e => e.PercentPerformanceGuarantee)
                .HasColumnType("smallmoney")
                .HasColumnName("percent_performance_guarantee");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("start_date");
            entity.Property(e => e.TenderNumber)
                .HasMaxLength(50)
                .HasColumnName("tender_number");
            entity.Property(e => e.TotalPercentHeapByEstimation)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("total_percent_heap_by_estimation");
            entity.Property(e => e.TotalPercentHeapByImplementation)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("total_percent_heap_by_implementation");
        });

        modelBuilder.Entity<ProjectDate>(entity =>
        {
            entity.ToTable("project_dates");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EstDate)
                .HasColumnType("date")
                .HasColumnName("est_date");
            entity.Property(e => e.IdProject).HasColumnName("id_project");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
        });

        modelBuilder.Entity<ProjectDeliveryBag>(entity =>
        {
            entity.ToTable("project_delivery_bag");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeliveryBagId).HasColumnName("delivery_bag_id");
            entity.Property(e => e.IsChecked).HasColumnName("isChecked");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");

            entity.HasOne(d => d.DeliveryBag).WithMany(p => p.ProjectDeliveryBags)
                .HasForeignKey(d => d.DeliveryBagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_project_delivery_bag_delivery_bag");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectDeliveryBags)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_project_delivery_bag_project");
        });

        modelBuilder.Entity<ProjectFunding>(entity =>
        {
            entity.ToTable("project_fundings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdFunding).HasColumnName("id_funding");
            entity.Property(e => e.IdProject).HasColumnName("id_project");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.MoneyLeft)
                .HasColumnType("money")
                .HasColumnName("money_left");
            entity.Property(e => e.ProjectBudget)
                .HasColumnType("money")
                .HasColumnName("project_budget");
        });

        modelBuilder.Entity<ProjectStage>(entity =>
        {
            entity.ToTable("project_stage");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ProjectStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_status");

            entity.ToTable("project_status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.HexColor)
                .HasMaxLength(10)
                .HasColumnName("hex_color");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<PsChangesLog>(entity =>
        {
            entity.ToTable("ps_changes_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasMaxLength(200)
                .HasColumnName("comment");
            entity.Property(e => e.LogDate)
                .HasColumnType("datetime")
                .HasColumnName("log_date");
            entity.Property(e => e.PaymentSheetId).HasColumnName("payment_sheet_id");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.UserFullName)
                .HasMaxLength(50)
                .HasColumnName("user_full_name");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<ReportsList>(entity =>
        {
            entity.ToTable("reports_list");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("active");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.PageName)
                .HasMaxLength(50)
                .HasColumnName("pageName");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<RequestAnswer>(entity =>
        {
            entity.ToTable("request_answer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnswerTxt).HasColumnName("answer_txt");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<RequestForOffer>(entity =>
        {
            entity.ToTable("request_for_offer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdChoosenSupplier).HasColumnName("id_choosen_supplier");
            entity.Property(e => e.IdProject).HasColumnName("id_project");
            entity.Property(e => e.IdRequestStatus).HasColumnName("id_request_status");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.RequestContent)
                .HasColumnType("text")
                .HasColumnName("request_content");
            entity.Property(e => e.RequestTitle)
                .HasMaxLength(400)
                .HasColumnName("request_title");
            entity.Property(e => e.RequestToDate)
                .HasColumnType("date")
                .HasColumnName("request_to_date");
            entity.Property(e => e.ToSuppliersArr)
                .HasMaxLength(200)
                .HasColumnName("to_suppliers_arr");
        });

        modelBuilder.Entity<RequestForOfferToSupplier>(entity =>
        {
            entity.ToTable("request_for_offer_to_supplier");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasMaxLength(200)
                .HasColumnName("comment");
            entity.Property(e => e.IdRequestForOffer).HasColumnName("id_request_for_offer");
            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.IdSupplierRequestStatus).HasColumnName("id_supplier_request_status");
            entity.Property(e => e.IsSentOffer).HasColumnName("is_sent_offer");
            entity.Property(e => e.SendDatetime)
                .HasColumnType("datetime")
                .HasColumnName("send_datetime");
        });

        modelBuilder.Entity<RequestTemplate>(entity =>
        {
            entity.ToTable("request_template");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.CommitmentText).HasColumnName("commitment_text");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<RequestTemplateDefApprover>(entity =>
        {
            entity.ToTable("request_template_def_approver");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdApprover).HasColumnName("id_approver");
            entity.Property(e => e.IdRequestTemplate).HasColumnName("id_request_template");

            entity.HasOne(d => d.IdApproverNavigation).WithMany(p => p.RequestTemplateDefApprovers)
                .HasForeignKey(d => d.IdApprover)
                .HasConstraintName("FK_request_template_def_approver_auth_request_approvers");

            entity.HasOne(d => d.IdRequestTemplateNavigation).WithMany(p => p.RequestTemplateDefApprovers)
                .HasForeignKey(d => d.IdRequestTemplate)
                .HasConstraintName("FK_request_template_def_approver_request_template");
        });

        modelBuilder.Entity<RequestTemplateOption>(entity =>
        {
            entity.ToTable("request_template_option");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdRequestTemplate).HasColumnName("id_request_template");
            entity.Property(e => e.OptionText).HasColumnName("option_text");
            entity.Property(e => e.OptionType)
                .HasMaxLength(50)
                .HasColumnName("option_type");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("role");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsAdmin).HasColumnName("is_admin");
            entity.Property(e => e.IsApprover).HasColumnName("is_approver");
            entity.Property(e => e.IsAuthRequestSet).HasColumnName("is_auth_request_set");
            entity.Property(e => e.IsBlocked).HasColumnName("is_blocked");
            entity.Property(e => e.IsDicManager).HasColumnName("is_dic_manager");
            entity.Property(e => e.IsRead).HasColumnName("is_read");
            entity.Property(e => e.IsReport).HasColumnName("is_report");
            entity.Property(e => e.IsSignature).HasColumnName("is_signature");
            entity.Property(e => e.IsWrite).HasColumnName("is_write");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<RolePageFunction>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.PageFunctionId });

            entity.ToTable("role_page_function");

            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.PageFunctionId).HasColumnName("page_function_id");
            entity.Property(e => e.IsBlocked)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_blocked");
            entity.Property(e => e.IsRead)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_read");
            entity.Property(e => e.IsReport)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_report");
            entity.Property(e => e.IsSignature)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_signature");
            entity.Property(e => e.IsWrite)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_write");

            entity.HasOne(d => d.PageFunction).WithMany(p => p.RolePageFunctions)
                .HasPrincipalKey(p => p.PageFunctionId)
                .HasForeignKey(d => d.PageFunctionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_role_page_function_role_pages_functions");

            entity.HasOne(d => d.Role).WithMany(p => p.RolePageFunctions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_role_page_function_role");
        });

        modelBuilder.Entity<RolePagesFunction>(entity =>
        {
            entity.ToTable("role_pages_functions");

            entity.HasIndex(e => e.PageFunctionId, "UQ_role_pages_functions").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.PageFunctionId).HasColumnName("page_function_id");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<ServiceLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__service___3213E83F70A7E93B");

            entity.ToTable("service_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuhtorityName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("auhtority_name");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.TypeOfActivity)
                .IsUnicode(false)
                .HasColumnName("type_of_activity");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.ToTable("supplier");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressCity)
                .HasMaxLength(50)
                .HasColumnName("address_city");
            entity.Property(e => e.AddressMikud)
                .HasMaxLength(10)
                .HasColumnName("address_mikud");
            entity.Property(e => e.AddressName)
                .HasMaxLength(100)
                .HasColumnName("address_name");
            entity.Property(e => e.AddressNum)
                .HasMaxLength(10)
                .HasColumnName("address_num");
            entity.Property(e => e.Cellphone)
                .HasMaxLength(50)
                .HasColumnName("cellphone");
            entity.Property(e => e.Comment)
                .HasColumnType("ntext")
                .HasColumnName("comment");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .HasColumnName("fax");
            entity.Property(e => e.IdSupplierType).HasColumnName("id_supplier_type");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_active");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.SupplierHp).HasColumnName("supplier_hp");
            entity.Property(e => e.SupplierNumber).HasColumnName("supplier_number");
        });

        modelBuilder.Entity<SupplierType>(entity =>
        {
            entity.ToTable("supplier_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SysUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_users");

            entity.ToTable("sys_user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .HasColumnName("address");
            entity.Property(e => e.Cellphone)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("cellphone");
            entity.Property(e => e.Comment)
                .HasColumnType("ntext")
                .HasColumnName("comment");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasColumnName("fname");
            entity.Property(e => e.IdProject).HasColumnName("id_project");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_active");
            entity.Property(e => e.IsAdmin).HasColumnName("is_admin");
            entity.Property(e => e.IsAuthsApproverManager).HasColumnName("is_auths_approver_manager");
            entity.Property(e => e.IsAuthsManager).HasColumnName("is_auths_manager");
            entity.Property(e => e.IsAuthsSupervisor).HasColumnName("is_auths_supervisor");
            entity.Property(e => e.IsCoordinationManager).HasColumnName("is_coordination_manager");
            entity.Property(e => e.IsProjectManager).HasColumnName("is_project_manager");
            entity.Property(e => e.IsTempTransGetter).HasColumnName("is_temp_trans_getter");
            entity.Property(e => e.IsTempTransManager).HasColumnName("is_temp_trans_manager");
            entity.Property(e => e.IsViewingDynamicRequests).HasColumnName("is_viewing_dynamic_requests");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("lname");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.SysUsers)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("FK_sys_user_role");
        });

        modelBuilder.Entity<System>(entity =>
        {
            entity.ToTable("system");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.ExpDate)
                .HasColumnType("date")
                .HasColumnName("exp_date");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SystemContent>(entity =>
        {
            entity.ToTable("system_contents");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentText).HasColumnName("content_text");
            entity.Property(e => e.IsMessageTemplate).HasColumnName("is_message_template");
            entity.Property(e => e.KeyName)
                .HasMaxLength(50)
                .HasColumnName("key_name");
            entity.Property(e => e.KeyTitle)
                .HasMaxLength(250)
                .HasColumnName("key_title");
        });

        modelBuilder.Entity<SystemSetting>(entity =>
        {
            entity.ToTable("system_settings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Extra)
                .HasMaxLength(500)
                .HasColumnName("extra");
            entity.Property(e => e.IsImage).HasColumnName("is_image");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<TypeActivityList>(entity =>
        {
            entity.ToTable("type_activity_list");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<UserLog>(entity =>
        {
            entity.ToTable("user_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivityType).HasColumnName("activityType");
            entity.Property(e => e.DateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateTime");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.UserLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_log_sys_user");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
