using System;
using System.Collections.Generic;

namespace MyStoreApp.Models;

public partial class AccountMember
{
    public int MemberId { get; set; }

    public string MemberPassword { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string MemberRole { get; set; } = null!;

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
