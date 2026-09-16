using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class FriendConfirm
{
    public int FriConfirmId { get; set; }

    public string? FriConfirmMeStudid { get; set; }

    public string? FriConfirmFriendStudid { get; set; }

    public DateTime? FriConfirmDate { get; set; }

    public string? FriConfirmIsActive { get; set; }
}
