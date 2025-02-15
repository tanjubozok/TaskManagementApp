﻿namespace TaskManagementApp.Domain.Entities;

public class Notification : BaseEntity
{
    public string Description { get; set; } = null!;
    public bool State { get; set; }

    public int AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
}
