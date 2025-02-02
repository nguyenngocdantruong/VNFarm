using System;
using System.Collections.Generic;

namespace VNFarm.Core.Models;

public partial class ProductTag
{
    public int IdProduct { get; set; }

    public int IdTag { get; set; }

    public virtual Product IdProductNavigation { get; set; } = null!;

    public virtual Tag IdTagNavigation { get; set; } = null!;
}
