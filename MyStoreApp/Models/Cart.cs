using System;
using System.Collections.Generic;

namespace MyStoreApp.Models;

public partial class Cart
{
    public int CartId { get; set; }

    public int MemberId { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual AccountMember Member { get; set; } = null!;
}
