using System;
using System.Collections.Generic;

namespace VNFarm.Core.Models;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? LastLogin { get; set; }

    public virtual ICollection<Chat> ChatReceivers { get; set; } = [];

    public virtual ICollection<Chat> ChatSenders { get; set; } = [];

    public virtual ICollection<Order> Orders { get; set; } = [];

    public virtual ICollection<Review> Reviews { get; set; } = [];

    public virtual ICollection<Store> Stores { get; set; } = [];

    public virtual ICollection<Wishlist> Wishlists { get; set; } = [];
}
