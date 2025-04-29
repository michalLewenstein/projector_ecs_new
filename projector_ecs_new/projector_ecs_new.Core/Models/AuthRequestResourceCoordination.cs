using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestResourceCoordination
{
    public int Id { get; set; }

    public int? IdAuthRequest { get; set; }

    public int? IdResource { get; set; }

    public int? ParticipantsNum { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public TimeSpan? FromHour { get; set; }

    public TimeSpan? ToHour { get; set; }

    public bool? IsRecurring { get; set; }

    public bool? DailyRecurring { get; set; }

    public bool? WeeklyRecurring { get; set; }

    public bool? MonthlyRecurring { get; set; }
}
