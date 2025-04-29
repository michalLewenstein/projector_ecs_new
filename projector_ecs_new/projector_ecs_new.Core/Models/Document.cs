using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class Document
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Filename { get; set; }

    public string? ContentType { get; set; }

    public int? IdUser { get; set; }

    public DateTime? UploadDate { get; set; }

    public int? IdProject { get; set; }

    public int? IdDocType { get; set; }

    public bool? IsVisible { get; set; }

    public int? IdAuthRequest { get; set; }

    public int? IdApprover { get; set; }

    public string? TypeApprover { get; set; }

    public int? IdAuthRequestDocType { get; set; }

    public int? IdAuthRequestCoordMsg { get; set; }

    public bool? ForTempTransApproval { get; set; }

    public bool? IsPublic { get; set; }

    public int? IdLayer { get; set; }

    public bool? IsCompilation { get; set; }

    public int? DirectoryInfoId { get; set; }

    public virtual DirectoryInfo? DirectoryInfo { get; set; }
}
