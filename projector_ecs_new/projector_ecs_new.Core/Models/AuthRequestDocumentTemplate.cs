using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestDocumentTemplate
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? IdDupFrom { get; set; }

    public int? IdUserCreated { get; set; }

    public DateTime? CreatedDatetime { get; set; }
}
