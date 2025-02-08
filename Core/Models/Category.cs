using System;
using System.Collections.Generic;

namespace VNFarm.Core.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
}
