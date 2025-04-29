using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestDocumentTemplateElement
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public int? IdDocumentTemplate { get; set; }

    public int? IdDocumentElement { get; set; }

    public int? OrderInTemplate { get; set; }

    public int? IdParent { get; set; }

    public string? Title { get; set; }

    public string? Data { get; set; }
}
