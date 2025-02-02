using System;
using System.Collections.Generic;

namespace VNFarm.Core.Models;

public partial class Chat
{
    public int SenderId { get; set; }

    public int ReceiverId { get; set; }

    public string Message { get; set; } = null!;

    public DateTime? Timestamp { get; set; }

    public bool? IsRead { get; set; }

    public virtual User Receiver { get; set; } = null!;

    public virtual User Sender { get; set; } = null!;
}
