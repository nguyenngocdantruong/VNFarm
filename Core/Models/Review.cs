using System;
using System.Collections.Generic;

namespace VNFarm.Core.Models;

public partial class Review
{
    public int ProductId { get; set; }

    public int UserId { get; set; }

    public byte? Rating { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
