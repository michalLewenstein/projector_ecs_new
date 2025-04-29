using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ProjectDeliveryBag
{
    public int Id { get; set; }

    public int DeliveryBagId { get; set; }

    public int ProjectId { get; set; }

    public bool IsChecked { get; set; }

    public virtual DeliveryBag DeliveryBag { get; set; } = null!;

    public virtual Project Project { get; set; } = null!;
}
