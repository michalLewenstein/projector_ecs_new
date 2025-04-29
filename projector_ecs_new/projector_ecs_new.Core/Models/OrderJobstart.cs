using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class OrderJobstart
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public DateTime? DateOrder { get; set; }

    public string? ToOrder { get; set; }

    public string? Title { get; set; }

    public string? ProjectNumber { get; set; }

    public string? TenderSolution { get; set; }

    public string? StartOrderSum { get; set; }

    public string? PaymentCondition { get; set; }

    public short? TypeActivity { get; set; }

    public string? TypeActivityTxt { get; set; }
}
