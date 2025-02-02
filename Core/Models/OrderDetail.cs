using System;
using System.Collections.Generic;

namespace VNFarm.Core.Models;

public partial class OrderDetail
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public int UnitPrice { get; set; }

    public string Unit { get; set; } = null!;

    public long TotalPrice { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
