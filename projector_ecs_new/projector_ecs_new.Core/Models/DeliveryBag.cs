using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class DeliveryBag
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? IsForAllProject { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<ProjectDeliveryBag> ProjectDeliveryBags { get; } = new List<ProjectDeliveryBag>();
}
