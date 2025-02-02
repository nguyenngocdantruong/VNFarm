using System;
using System.Collections.Generic;

namespace VNFarm.Core.Models;

public partial class Product
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public string Name { get; set; } = null!;

    public int Price1 { get; set; }

    public int Price2 { get; set; }

    public int Quantity { get; set; }

    public string Unit { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public double ReviewAverage { get; set; }

    public int? ReviewCount { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = [];

    public virtual ICollection<Review> Reviews { get; set; } = [];

    public virtual Store Store { get; set; } = null!;

    public virtual ICollection<Wishlist> Wishlists { get; set; } = [];
}
