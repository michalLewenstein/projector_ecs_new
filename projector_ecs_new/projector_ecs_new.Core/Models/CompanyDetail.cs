using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class CompanyDetail
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Number { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public string? ApartmentNumber { get; set; }

    public string? ZipCode { get; set; }

    public byte? FontSize { get; set; }

    public byte? FontWeight { get; set; }

    public string? FontFamily { get; set; }

    public virtual ICollection<CompanyEmail> CompanyEmails { get; } = new List<CompanyEmail>();

    public virtual ICollection<CompanyFax> CompanyFaxes { get; } = new List<CompanyFax>();

    public virtual ICollection<CompanyLogo> CompanyLogos { get; } = new List<CompanyLogo>();

    public virtual ICollection<CompanyPhone> CompanyPhones { get; } = new List<CompanyPhone>();
}
