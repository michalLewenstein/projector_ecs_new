using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthorizedSignature
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public int UserId { get; set; }

    public int SignatureOrder { get; set; }
}
