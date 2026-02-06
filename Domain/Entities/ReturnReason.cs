using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReturnReason
{
    public int ReasonId { get; set; }

    public string? ReasonCode { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<ReturnOrderDetail> ReturnOrderDetails { get; set; } = new List<ReturnOrderDetail>();
}
