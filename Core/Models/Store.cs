using System;
using System.Collections.Generic;

namespace VNFarm.Core.Models;

public partial class Store
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string LogoUrl { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Order> Orders { get; set; } =[];

    public virtual ICollection<Product> Products { get; set; } = [];

    public virtual User User { get; set; } = null!;
}
