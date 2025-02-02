using System;
using System.Collections.Generic;

namespace VNFarm.Core.Models;

public partial class Order
{
    public int Id { get; set; }

    public int BuyerId { get; set; }

    public int StoreId { get; set; }

    public decimal TotalAmount { get; set; }

    public string Status { get; set; } = null!;

    public string PaymentMethod { get; set; } = null!;

    public string ShippingAddress { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual User Buyer { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = [];

    public virtual Store Store { get; set; } = null!;
}
