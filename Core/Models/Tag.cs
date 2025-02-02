using System;
using System.Collections.Generic;

namespace VNFarm.Core.Models;

public partial class Tag
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool AdminOnly { get; set; }
}
