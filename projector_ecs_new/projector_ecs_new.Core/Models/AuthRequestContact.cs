using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestContact
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public int? DefaultIdAuthority { get; set; }

    public string? Fullname { get; set; }

    public string? TzHp { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? CodeKey { get; set; }

    public string? CodeAuth { get; set; }

    public DateTime? ExpExpDate { get; set; }

    public bool? IsApproved { get; set; }

    public string? SettingsObj { get; set; }

    public string? Signature { get; set; }

    public bool? AppearsOnNewsDistributionList { get; set; }

    public bool? IsActive { get; set; }
    
}
