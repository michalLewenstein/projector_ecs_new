using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? IdSupplierType { get; set; }

    public double? SupplierNumber { get; set; }

    public double? SupplierHp { get; set; }

    public string? AddressCity { get; set; }

    public string? AddressName { get; set; }

    public string? AddressNum { get; set; }

    public string? AddressMikud { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Cellphone { get; set; }

    public string? Email { get; set; }

    public string? Comment { get; set; }

    public bool? IsActive { get; set; }
}
