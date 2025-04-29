using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ArMtlApplicationAttachmentDetail
{
    public int Id { get; set; }

    public int? IdMtlApplication { get; set; }

    public int? EcsIdDocument { get; set; }

    public string? ApplicationId { get; set; }

    public string? ApplicationNumber { get; set; }

    public string? DocumentId { get; set; }

    public string? DocumentType { get; set; }

    public DateTime? DocumentCreatedOn { get; set; }

    public string? DocCreatedById { get; set; }

    public string? DocCreatedBy { get; set; }

    public DateTime? DocCreatedOn { get; set; }

    public string? DocUploadById { get; set; }

    public string? DocUploadBy { get; set; }

    public string? DocType { get; set; }

    public string? DocSize { get; set; }

    public string? AttachmentLink { get; set; }

    public string? AttachedDocumentsToRequestFile { get; set; }

    public string? FileName { get; set; }
}
