using System;
using System.Collections.Generic;

namespace ProductDbFirstApproch.Models;

public partial class ProductTbl
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal ProductPrice { get; set; }

    public DateOnly? ProductDate { get; set; }

    public virtual OrderItemId? OrderItemId { get; set; }
}
