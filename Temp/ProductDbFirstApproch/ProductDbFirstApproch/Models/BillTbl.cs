using System;
using System.Collections.Generic;

namespace ProductDbFirstApproch.Models;

public partial class BillTbl
{
    public int BillId { get; set; }

    public int OrderId { get; set; }

    public virtual OrderTbl Order { get; set; } = null!;
}
