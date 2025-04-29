using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class ContactDetail
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Fulladdress { get; set; }

    public string? Fax { get; set; }

    public string? Cellphone1 { get; set; }

    public string? Cellphone2 { get; set; }

    public string? Email { get; set; }

    public int? IdSupplier { get; set; }
}
