using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestResource
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? IdResourceType { get; set; }

    public int? IdResourceSubType { get; set; }

    public int? IdResourceStatus { get; set; }

    public int? IdSizeType { get; set; }

    public int? SizeValue { get; set; }

    public int? IdParentResource { get; set; }

    public string? Geometrics { get; set; }

    public int? MaxPeople { get; set; }

    public int? NormalPeople { get; set; }

    public string? Comments { get; set; }

    public int? MaxNoiseLevel { get; set; }

    public bool? IsActive { get; set; }

    public string? Location { get; set; }

    public string? Instructions { get; set; }
}
