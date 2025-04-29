using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class SysUser
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public int? IdRole { get; set; }

    public int? IdSupplier { get; set; }

    public int? IdProject { get; set; }

    public string? Lname { get; set; }

    public string? Fname { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Cellphone { get; set; }

    public string? Comment { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsProjectManager { get; set; }

    public bool? IsAuthsManager { get; set; }

    public bool? IsAuthsApproverManager { get; set; }

    public bool? IsAdmin { get; set; }

    public bool? IsCoordinationManager { get; set; }

    public bool? IsAuthsSupervisor { get; set; }

    public bool? IsTempTransGetter { get; set; }

    public bool? IsTempTransManager { get; set; }

    public bool? IsViewingDynamicRequests { get; set; }

    public virtual Role? IdRoleNavigation { get; set; }

    public virtual ICollection<UserLog> UserLogs { get; } = new List<UserLog>();
}
