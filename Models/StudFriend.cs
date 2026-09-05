using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudFriend
{
    public int FriendId { get; set; }

    public string? FriendCode { get; set; }

    public string? FriendMeStudid { get; set; }

    public string? FriendFriendsStudid { get; set; }

    public string? FriendRelation { get; set; }

    public string? FriendStatus { get; set; }

    public DateTime? FriendDate { get; set; }

    public DateTime? FriendDeleteDate { get; set; }

    public string? FriendIsDelete { get; set; }
}
