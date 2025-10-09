﻿namespace NAME_WIP_BACKEND.Models;

public class FriendRecommendation
{
    public int Id { get; set; }
    public int RecommendedForId { get; set; }
    public int RecommendedWhoId { get; set; }
    public int RecValue { get; set; }

    public User RecommendedFor { get; set; } = null!;
    public User RecommendedWho { get; set; } = null!;
}