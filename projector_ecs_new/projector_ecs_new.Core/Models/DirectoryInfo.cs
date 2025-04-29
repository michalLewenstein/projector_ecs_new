using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class DirectoryInfo
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? RequestId { get; set; }

    public int? ParentId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IdUser { get; set; }

    public virtual ICollection<Document> Documents { get; } = new List<Document>();

    public virtual ICollection<DirectoryInfo> InverseParent { get; } = new List<DirectoryInfo>();

    public virtual DirectoryInfo? Parent { get; set; }
}
